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
    public partial class PatientHistoryForm : Form
    {
        private Patient patient;
        private DataManager dataManager;

        public PatientHistoryForm(Patient p)
        {
            InitializeComponent();
            patient = p;
            dataManager = DataManager.Instance;

            lblPatientInfo.Text = $"Пациент: {patient.GetFullName()} | Возраст: {patient.GetAge()} лет | Мед. карта: {patient.MedicalCardNumber}";

            LoadHistory();
            LoadMedicalCard();
        }

        private void LoadHistory()
        {
            var history = dataManager.GetPatientAppointments(patient.Id)
                .Where(a => a.Status == AppointmentStatus.Completed)
                .OrderByDescending(a => a.AppointmentDateTime)
                .Select(a => new
                {
                    Дата = a.AppointmentDateTime.ToString("dd.MM.yyyy HH:mm"),
                    Врач = a.DoctorName,
                    Примечания = a.Notes
                }).ToList();

            if (history.Any())
            {
                dgvHistory.DataSource = history;
                lblNoHistory.Visible = false;
            }
            else
            {
                lblNoHistory.Visible = true;
                dgvHistory.Visible = false;
            }

            lblHistoryCount.Text = $"Всего посещений: {history.Count}";
        }

        private void LoadMedicalCard()
        {
            var card = patient.MedicalCard;

            // Группа крови
            txtBloodType.Text = string.IsNullOrEmpty(card.BloodType) ? "Не указана" : card.BloodType;

            // Аллергии
            if (card.Allergies.Any())
            {
                txtAllergies.Text = string.Join(", ", card.Allergies);
            }
            else
            {
                txtAllergies.Text = "Нет";
            }

            // Хронические заболевания
            if (card.ChronicDiseases.Any())
            {
                txtChronicDiseases.Text = string.Join(", ", card.ChronicDiseases);
            }
            else
            {
                txtChronicDiseases.Text = "Нет";
            }

            // Записи в медкарте
            if (card.Records.Any())
            {
                var records = card.Records.OrderByDescending(r => r.VisitDate).Select(r => new
                {
                    Дата = r.VisitDate.ToString("dd.MM.yyyy"),
                    Врач = r.DoctorName,
                    Диагноз = r.Diagnosis,
                    Лечение = r.Treatment
                }).ToList();

                dgvMedicalRecords.DataSource = records;
            }
            else
            {
                dgvMedicalRecords.DataSource = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
