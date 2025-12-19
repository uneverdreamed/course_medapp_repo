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
    public partial class ScheduleForm : Form
    {
        private DataManager dataManager;

        public ScheduleForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadDoctors();
            dtpDate.Value = DateTime.Today;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedValue == null)
            {
                MessageBox.Show("Выберите врача", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctor = (Doctor)cmbDoctor.SelectedValue;
            var date = dtpDate.Value.Date;

            lblDoctorInfo.Text = $"Врач: {doctor.GetFullName()} | Специализация: {doctor.Specialization} | Дата: {date:dd.MM.yyyy}";

            var appointments = dataManager.GetDoctorAppointments(doctor.Id, date);

            if (!appointments.Any())
            {
                lblNoAppointments.Visible = true;
                dgvSchedule.Visible = false;
            }
            else
            {
                lblNoAppointments.Visible = false;
                dgvSchedule.Visible = true;

                var schedule = appointments.Select(a => new
                {
                    Время = a.AppointmentDateTime.ToString("HH:mm"),
                    Длительность = $"{a.DurationMinutes} мин",
                    Пациент = a.PatientName,
                    Статус = GetStatusText(a.Status),
                    Примечания = a.Notes
                }).ToList();

                dgvSchedule.DataSource = schedule;
            }
        }

        private string GetStatusText(AppointmentStatus status)
        {
            return status switch
            {
                AppointmentStatus.Scheduled => "Запланирована",
                AppointmentStatus.Completed => "Завершена",
                AppointmentStatus.Cancelled => "Отменена",
                _ => "Неизвестно"
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
