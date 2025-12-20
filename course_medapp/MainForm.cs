using System;
using System.Drawing;
using System.Windows.Forms;
using course_medapp.Services;
using course_medapp;

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
            lblPatientsValue.Text = dataManager.Patients.Count.ToString();
            lblDoctorsValue.Text = dataManager.Doctors.Count.ToString();

            var upcomingCount = dataManager.GetUpcomingAppointments(7).Count;
            lblAppointmentsValue.Text = upcomingCount.ToString();
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

        private void panelStatDoctors_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPatientsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblDoctorsTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}