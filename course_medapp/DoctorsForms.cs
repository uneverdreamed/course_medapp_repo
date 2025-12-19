using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using course_medapp;
using course_medapp.Services;

namespace course_medapp.Forms
{
    public partial class DoctorsForm : Form
    {
        private DataManager dataManager;

        public DoctorsForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            dgvDoctors.DataSource = null;
            var doctors = dataManager.Doctors.Select(d => new
            {
                d.Id,
                ФИО = d.GetFullName(),
                Специализация = d.Specialization,
                Стаж = $"{d.ExperienceYears} лет",
                Возраст = d.GetAge(),
                Телефон = d.PhoneNumber,
                Лицензия = d.LicenseNumber
            }).ToList();

            dgvDoctors.DataSource = doctors;
            dgvDoctors.Columns["Id"].Visible = false;
            lblTotal.Text = $"Всего врачей: {doctors.Count}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoctorEditForm editForm = new DoctorEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadDoctors();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите врача для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string doctorId = dgvDoctors.SelectedRows[0].Cells["Id"].Value.ToString();
            var doctor = dataManager.GetDoctorById(doctorId);

            DoctorEditForm editForm = new DoctorEditForm(doctor);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadDoctors();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите врача для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string doctorName = dgvDoctors.SelectedRows[0].Cells["ФИО"].Value.ToString();
            var result = MessageBox.Show($"Вы уверены, что хотите удалить врача {doctorName}?\n\nВсе будущие записи к этому врачу будут отменены.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string doctorId = dgvDoctors.SelectedRows[0].Cells["Id"].Value.ToString();
                    dataManager.DeleteDoctor(doctorId);
                    LoadDoctors();
                    MessageBox.Show("Врач успешно удалён", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadDoctors();
                return;
            }

            var filtered = dataManager.Doctors
                .Where(d => d.FirstName.ToLower().Contains(searchText) ||
                           d.LastName.ToLower().Contains(searchText) ||
                           d.Specialization.ToLower().Contains(searchText))
                .Select(d => new
                {
                    d.Id,
                    ФИО = d.GetFullName(),
                    Специализация = d.Specialization,
                    Стаж = $"{d.ExperienceYears} лет",
                    Возраст = d.GetAge(),
                    Телефон = d.PhoneNumber,
                    Лицензия = d.LicenseNumber
                }).ToList();

            dgvDoctors.DataSource = filtered;
            dgvDoctors.Columns["Id"].Visible = false;
            lblTotal.Text = $"Найдено: {filtered.Count}";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
