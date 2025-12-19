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
    public partial class AppointmentsForm : Form
    {
        private DataManager dataManager;

        public AppointmentsForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = null;
            var appointments = dataManager.Appointments
                .OrderByDescending(a => a.AppointmentDateTime)
                .Select(a => new
                {
                    a.Id,
                    Дата = a.AppointmentDateTime.ToString("dd.MM.yyyy"),
                    Время = a.AppointmentDateTime.ToString("HH:mm"),
                    Пациент = a.PatientName,
                    Врач = a.DoctorName,
                    Статус = GetStatusText(a.Status),
                    Примечания = a.Notes
                }).ToList();

            dgvAppointments.DataSource = appointments;
            dgvAppointments.Columns["Id"].Visible = false;
            lblTotal.Text = $"Всего записей: {appointments.Count}";
        }

        private string GetStatusText(AppointmentStatus status)
        {
            return status switch
            {
                AppointmentStatus.Scheduled => "Запланирована",
                AppointmentStatus.Completed => "Завершена",
                AppointmentStatus.Cancelled => "Отменена",
                AppointmentStatus.NoShow => "Не пришёл",
                _ => "Неизвестно"
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AppointmentEditForm editForm = new AppointmentEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadAppointments();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для отмены", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string appointmentId = dgvAppointments.SelectedRows[0].Cells["Id"].Value.ToString();
            var appointment = dataManager.Appointments.FirstOrDefault(a => a.Id == appointmentId);

            if (appointment == null)
            {
                MessageBox.Show("Запись не найдена", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!appointment.CanBeCancelled())
            {
                MessageBox.Show("Эту запись нельзя отменить.\nОтменить можно только запланированные записи за 2+ часа до приёма.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Вы уверены, что хотите отменить запись?\n\n" +
                $"Пациент: {appointment.PatientName}\n" +
                $"Врач: {appointment.DoctorName}\n" +
                $"Дата: {appointment.AppointmentDateTime:dd.MM.yyyy HH:mm}",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dataManager.CancelAppointment(appointmentId);
                    LoadAppointments();
                    MessageBox.Show("Запись отменена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка отмены: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для завершения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string appointmentId = dgvAppointments.SelectedRows[0].Cells["Id"].Value.ToString();

            var result = MessageBox.Show("Отметить запись как завершённую?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dataManager.CompleteAppointment(appointmentId);
                    LoadAppointments();
                    MessageBox.Show("Запись завершена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0) // Все
            {
                LoadAppointments();
                return;
            }

            var allAppointments = dataManager.Appointments.OrderByDescending(a => a.AppointmentDateTime);

            var filtered = cmbFilter.SelectedIndex switch
            {
                1 => allAppointments.Where(a => a.Status == AppointmentStatus.Scheduled), // Запланированные
                2 => allAppointments.Where(a => a.Status == AppointmentStatus.Completed), // Завершённые
                3 => allAppointments.Where(a => a.Status == AppointmentStatus.Cancelled), // Отменённые
                4 => allAppointments.Where(a => a.AppointmentDateTime.Date == DateTime.Today), // Сегодня
                _ => allAppointments
            };

            var result = filtered.Select(a => new
            {
                a.Id,
                Дата = a.AppointmentDateTime.ToString("dd.MM.yyyy"),
                Время = a.AppointmentDateTime.ToString("HH:mm"),
                Пациент = a.PatientName,
                Врач = a.DoctorName,
                Статус = GetStatusText(a.Status),
                Примечания = a.Notes
            }).ToList();

            dgvAppointments.DataSource = result;
            dgvAppointments.Columns["Id"].Visible = false;
            lblTotal.Text = $"Найдено: {result.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}