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
using Microsoft.VisualBasic;

namespace course_medapp.Forms
{
    public partial class AppointmentEditForm : Form
    {
        private DataManager dataManager;

        public AppointmentEditForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadDoctors();
            LoadPatients();

            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Today.AddHours(9);
        }

        private void LoadDoctors()
        {
            cmbDoctor.DataSource = null;
            cmbDoctor.DisplayMember = "DisplayText";
            cmbDoctor.ValueMember = "Doctor";

            var doctors = dataManager.Doctors.Select(d => new
            {
                Doctor = d,
                DisplayText = $"{d.GetFullName()} - {d.Specialization}"
            }).ToList();

            cmbDoctor.DataSource = doctors;
        }

        private void LoadPatients()
        {
            cmbPatient.DataSource = null;
            cmbPatient.DisplayMember = "DisplayText";
            cmbPatient.ValueMember = "Patient";

            var patients = dataManager.Patients.Select(p => new
            {
                Patient = p,
                DisplayText = $"{p.GetFullName()} - {p.MedicalCardNumber}"
            }).ToList();

            cmbPatient.DataSource = patients;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedValue == null || cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("Выберите врача и пациента", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctor = (Doctor)cmbDoctor.SelectedValue;
            var patient = (Patient)cmbPatient.SelectedValue;

            DateTime appointmentDateTime = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay);

            if (appointmentDateTime < DateTime.Now)
            {
                MessageBox.Show("Нельзя создать запись на прошедшее время", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var appointment = new Appointment
                {
                    DoctorId = doctor.Id,
                    DoctorName = doctor.GetFullName(),
                    PatientId = patient.Id,
                    PatientName = patient.GetFullName(),
                    AppointmentDateTime = appointmentDateTime,
                    DurationMinutes = (int)numDuration.Value,
                    Notes = txtNotes.Text.Trim()
                };

                dataManager.AddAppointment(appointment);

                MessageBox.Show("Запись успешно создана", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания записи: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}