using System;
using System.Drawing;
using System.Windows.Forms;
using course_medapp.Services;

namespace course_medapp.Forms
{
    public partial class MainForm : Form
    {
        private DataManager dataManager;

        public MainForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            // Обновляем статистику на главном экране
            lblTotalPatients.Text = $"Пациентов: {dataManager.Patients.Count}";
            lblTotalDoctors.Text = $"Врачей: {dataManager.Doctors.Count}";

            var upcomingCount = dataManager.GetUpcomingAppointments(7).Count;
            lblUpcomingAppointments.Text = $"Записей на неделю: {upcomingCount}";
        }

        // Обработчики кнопок главного меню
        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.ShowDialog();
            UpdateStatistics(); // Обновляем статистику после закрытия формы
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.ShowDialog();
            UpdateStatistics();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.ShowDialog();
            UpdateStatistics();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.ShowDialog();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm();
            departmentsForm.ShowDialog();
            UpdateStatistics();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}