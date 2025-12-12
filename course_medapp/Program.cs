using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_medapp
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        protected Person()
        {
            Id = Guid.NewGuid().ToString();
        }

        protected Person(string firstName, string lastName, string phone, DateTime dob)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phone;
            DateOfBirth = dob;
        }

        public string GetFullName() => $"{LastName} {FirstName}";

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
        public virtual string GetInfo()
        {
            return $"{GetFullName()}, {GetAge()} лет, тел: {PhoneNumber}";
        }
        public class MedicalRecord
        {
            public string Id { get; set; }
            public DateTime VisitDate { get; set; }
            public string DoctorId { get; set; }
            public string DoctorName { get; set; }
            public string Diagnosis { get; set; }
            public string Treatment { get; set; }
            public string Notes { get; set; }
            public List<string> Prescriptions { get; set; }

            public MedicalRecord()
            {
                Id = Guid.NewGuid().ToString();
                VisitDate = DateTime.Now;
                Prescriptions = new List<string>();
            }
        }

        public class MedicalCard
        {
            public string PatientId { get; set; }
            public List<MedicalRecord> Records { get; private set; }
            public List<string> Allergies { get; set; }
            public List<string> ChronicDiseases { get; set; }
            public string BloodType { get; set; }

            public MedicalCard(string patientId)
            {
                PatientId = patientId;
                Records = new List<MedicalRecord>();
                Allergies = new List<string>();
                ChronicDiseases = new List<string>();
            }

            public void AddRecord(MedicalRecord record)
            {
                Records.Add(record);
            }

            public List<MedicalRecord> GetRecordsByDoctor(string doctorId)
            {
                return Records.Where(r => r.DoctorId == doctorId).ToList();
            }

            public List<MedicalRecord> GetRecordsByDateRange(DateTime from, DateTime to)
            {
                return Records.Where(r => r.VisitDate >= from && r.VisitDate <= to).ToList();
            }
        }

        internal static class Program
        {
            /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
