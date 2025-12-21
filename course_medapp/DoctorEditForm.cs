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
    public partial class DoctorEditForm : Form
    {
        private DataManager dataManager;
        private Doctor doctor;
        private bool isEditMode;

        public DoctorEditForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            isEditMode = false;
            this.Text = "Добавить врача";
            lblTitle.Text = "Добавление врача:";
            LoadDepartments();
            LoadExperience();
        }

        public DoctorEditForm(Doctor existingDoctor)
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            doctor = existingDoctor;
            isEditMode = true;
            this.Text = "Редактировать врача";
            lblTitle.Text = "Редактирование врача:";
            LoadDepartments();
            LoadExperience();
            LoadDoctorData();
        }

        private void LoadDepartments()
        {
            cmbDepartment.Items.Clear();
            cmbDepartment.Items.Add("-- Не выбрано --");

            foreach (var dept in dataManager.Departments)
            {
                cmbDepartment.Items.Add(dept.Name);
            }

            cmbDepartment.SelectedIndex = 0;
        }

        private void LoadExperience()
        {
            cmbExperience.Items.Clear();
            for (int i = 0; i <= 50; i++)
            {
                cmbExperience.Items.Add(i.ToString());
            }
            cmbExperience.SelectedIndex = 0;
        }

        private void LoadDoctorData()
        {
            txtFirstName.Text = doctor.FirstName;
            txtLastName.Text = doctor.LastName;
            txtMiddleName.Text = doctor.MiddleName ?? "";
            txtPhone.Text = doctor.PhoneNumber;
            dtpBirthDate.Value = doctor.DateOfBirth;
            txtSpecialization.Text = doctor.Specialization;
            txtLicense.Text = doctor.LicenseNumber;
            cmbExperience.SelectedIndex = doctor.ExperienceYears;

            // Загружаем отделение
            if (!string.IsNullOrEmpty(doctor.DepartmentId))
            {
                var department = dataManager.GetDepartmentById(doctor.DepartmentId);
                if (department != null)
                {
                    int index = cmbDepartment.Items.IndexOf(department.Name);
                    if (index >= 0)
                        cmbDepartment.SelectedIndex = index;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                string departmentId = "";
                if (cmbDepartment.SelectedIndex > 0)
                {
                    string deptName = cmbDepartment.SelectedItem.ToString();
                    var dept = dataManager.Departments.FirstOrDefault(d => d.Name == deptName);
                    if (dept != null)
                        departmentId = dept.Id;
                }

                if (isEditMode)
                {
                    // Редактирование существующего врача
                    doctor.FirstName = txtFirstName.Text.Trim();
                    doctor.LastName = txtLastName.Text.Trim();
                    doctor.MiddleName = string.IsNullOrWhiteSpace(txtMiddleName.Text) ? null : txtMiddleName.Text.Trim();
                    doctor.PhoneNumber = txtPhone.Text.Trim();
                    doctor.DateOfBirth = dtpBirthDate.Value;
                    doctor.Specialization = txtSpecialization.Text.Trim();
                    doctor.LicenseNumber = txtLicense.Text.Trim();
                    doctor.ExperienceYears = cmbExperience.SelectedIndex;
                    doctor.DepartmentId = departmentId;

                    dataManager.UpdateDoctor(doctor);
                    MessageBox.Show("Данные врача обновлены", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Добавление нового врача
                    var newDoctor = new Doctor(
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        txtPhone.Text.Trim(),
                        dtpBirthDate.Value,
                        txtSpecialization.Text.Trim(),
                        txtLicense.Text.Trim(),
                        cmbExperience.SelectedIndex,
                        departmentId,
                        string.IsNullOrWhiteSpace(txtMiddleName.Text) ? null : txtMiddleName.Text.Trim()
                    );

                    dataManager.AddDoctor(newDoctor);

                    // Добавляем врача в отделение
                    if (!string.IsNullOrEmpty(departmentId))
                    {
                        var dept = dataManager.GetDepartmentById(departmentId);
                        if (dept != null)
                        {
                            dept.AddDoctor(newDoctor.Id);
                            dataManager.UpdateDepartment(dept);
                        }
                    }

                    MessageBox.Show("Врач успешно добавлен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введите имя врача", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию врача", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Введите номер телефона", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Введите специализацию", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecialization.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicense.Text))
            {
                MessageBox.Show("Введите номер лицензии", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicense.Focus();
                return false;
            }

            if (dtpBirthDate.Value >= DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DoctorEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
