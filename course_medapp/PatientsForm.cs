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
    public partial class PatientsForm : Form
    {
        private DataManager dataManager;

        public PatientsForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadPatients();
        }

        private void LoadPatients()
        {
            dgvPatients.DataSource = null;
            var patients = dataManager.Patients.Select(p => new
            {
                p.Id,
                ФИО = p.GetFullName(),
                Возраст = p.GetAge(),
                Телефон = p.PhoneNumber,
                МедКарта = p.MedicalCardNumber,
                Адрес = p.Address
            }).ToList();

            dgvPatients.DataSource = patients;
            dgvPatients.Columns["Id"].Visible = false;
            lblTotal.Text = $"Всего пациентов: {patients.Count}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientEditForm editForm = new PatientEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadPatients();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patientId = dgvPatients.SelectedRows[0].Cells["Id"].Value.ToString();
            var patient = dataManager.GetPatientById(patientId);

            PatientEditForm editForm = new PatientEditForm(patient);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadPatients();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patientName = dgvPatients.SelectedRows[0].Cells["ФИО"].Value.ToString();
            var result = MessageBox.Show($"Вы уверены, что хотите удалить пациента {patientName}?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string patientId = dgvPatients.SelectedRows[0].Cells["Id"].Value.ToString();
                    dataManager.DeletePatient(patientId);
                    LoadPatients();
                    MessageBox.Show("Пациент успешно удалён", "Успех",
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
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText) || searchText == "Поиск")
            {
                LoadPatients();
                return;
            }

            var filtered = dataManager.SearchPatients(searchText).Select(p => new
            {
                p.Id,
                ФИО = p.GetFullName(),
                Возраст = p.GetAge(),
                Телефон = p.PhoneNumber,
                МедКарта = p.MedicalCardNumber,
                Адрес = p.Address
            }).ToList();

            dgvPatients.DataSource = filtered;
            dgvPatients.Columns["Id"].Visible = false;
            lblTotal.Text = $"Найдено: {filtered.Count}";
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patientId = dgvPatients.SelectedRows[0].Cells["Id"].Value.ToString();
            var patient = dataManager.GetPatientById(patientId);

            PatientHistoryForm historyForm = new PatientHistoryForm(patient);
            historyForm.ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Поиск")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Поиск";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}