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
    public partial class PatientEditForm : Form
    {
        private DataManager dataManager;
        private Patient patient;
        private bool isEditMode;

        public PatientEditForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            isEditMode = false;
            this.Text = "Добавить пациента";
            lblTitle.Text = "Новый пациент";
        }

        public PatientEditForm(Patient existingPatient)
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            patient = existingPatient;
            isEditMode = true;
            this.Text = "Редактировать пациента";
            lblTitle.Text = "Редактирование пациента";
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtPhone.Text = patient.PhoneNumber;
            dtpBirthDate.Value = patient.DateOfBirth;
            txtAddress.Text = patient.Address;
            txtInsurance.Text = patient.InsuranceNumber;
            txtMedCardNumber.Text = patient.MedicalCardNumber;
            txtMedCardNumber.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                if (isEditMode)
                {
                    // Редактирование существующего пациента
                    patient.FirstName = txtFirstName.Text.Trim();
                    patient.LastName = txtLastName.Text.Trim();
                    patient.PhoneNumber = txtPhone.Text.Trim();
                    patient.DateOfBirth = dtpBirthDate.Value;
                    patient.Address = txtAddress.Text.Trim();
                    patient.InsuranceNumber = txtInsurance.Text.Trim();

                    dataManager.UpdatePatient(patient);
                    MessageBox.Show("Данные пациента обновлены", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Добавление нового пациента
                    var newPatient = new Patient(
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        txtPhone.Text.Trim(),
                        dtpBirthDate.Value,
                        txtAddress.Text.Trim(),
                        txtInsurance.Text.Trim()
                    );

                    dataManager.AddPatient(newPatient);
                    MessageBox.Show("Пациент успешно добавлен", "Успех",
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
                MessageBox.Show("Введите имя пациента", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введите фамилию пациента", "Ошибка",
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
    }
}