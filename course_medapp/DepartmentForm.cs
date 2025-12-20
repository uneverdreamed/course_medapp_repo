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
    public partial class DepartmentsForm : Form
    {
        private DataManager dataManager;

        public DepartmentsForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            dgvDepartments.DataSource = null;
            var departments = dataManager.Departments.Select(d => new
            {
                d.Id,
                Название = d.Name,
                Расположение = d.Location,
                Телефон = d.PhoneNumber,
                Описание = d.Description,
                КоличествоВрачей = d.DoctorIds.Count
            }).ToList();

            dgvDepartments.DataSource = departments;
            dgvDepartments.Columns["Id"].Visible = false;
            lblTotal.Text = $"Всего отделений: {departments.Count}";
        }

        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count == 0)
            {
                lblDoctors.Text = "Врачи отделения:";
                lstDoctors.Items.Clear();
                return;
            }

            string departmentId = dgvDepartments.SelectedRows[0].Cells["Id"].Value.ToString();
            string departmentName = dgvDepartments.SelectedRows[0].Cells["Название"].Value.ToString();

            var department = dataManager.GetDepartmentById(departmentId);
            if (department == null) return;

            lblDoctors.Text = $"Врачи отделения \"{departmentName}\":";

            lstDoctors.Items.Clear();
            foreach (var doctorId in department.DoctorIds)
            {
                var doctor = dataManager.GetDoctorById(doctorId);
                if (doctor != null)
                {
                    lstDoctors.Items.Add($"• {doctor.GetFullName()} - {doctor.Specialization}");
                }
            }

            if (lstDoctors.Items.Count == 0)
            {
                lstDoctors.Items.Add("(Нет врачей в этом отделении)");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDoctors_Click(object sender, EventArgs e)
        {

        }
    }
}