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

    public class Patient : Person
    {
        public string MedicalCardNumber { get; set; }
        public string Address { get; set; }
        public string InsuranceNumber { get; set; }
        public MedicalCard MedicalCard { get; set; }

        public Patient() : base()
        {
            MedicalCardNumber = $"MC-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
            MedicalCard = new MedicalCard(Id);
        }

        public Patient(string firstName, string lastName, string phone, DateTime dob, string address, string insurance)
            : base(firstName, lastName, phone, dob)
        {
            MedicalCardNumber = $"MC-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
            Address = address;
            InsuranceNumber = insurance;
            MedicalCard = new MedicalCard(Id);
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Карта: {MedicalCardNumber}";
        }
    }
    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Cancelled,
        NoShow
    }

    public class Appointment
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public int DurationMinutes { get; set; }
        public AppointmentStatus Status { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }

        public Appointment()
        {
            Id = Guid.NewGuid().ToString();
            DurationMinutes = 30;
            Status = AppointmentStatus.Scheduled;
            CreatedDate = DateTime.Now;
        }
        public bool CanBeCancelled()
        {
            return Status == AppointmentStatus.Scheduled &&
                   AppointmentDateTime > DateTime.Now.AddHours(2);
        }
        public void Cancel()
        {
            if (CanBeCancelled())
            {
                Status = AppointmentStatus.Cancelled;
            }
            else
            {
                throw new InvalidOperationException("Невозможно отменить запись");
            }
        }
        public void Complete()
        {
            if (Status == AppointmentStatus.Scheduled)
            {
                Status = AppointmentStatus.Completed;
            }
        }
    }

    public class WorkingHours
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsWorkingDay { get; set; }
    }

    public class TimeSlot
    {
        public DateTime DateTime { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class Schedule
    {
        public string DoctorId { get; set; }
        public Dictionary<DayOfWeek, WorkingHours> WeekSchedule { get; set; }
        public List<TimeSlot> AvailableSlots { get; private set; }

        public Schedule(string doctorId)
        {
            DoctorId = doctorId;
            WeekSchedule = new Dictionary<DayOfWeek, WorkingHours>();
            AvailableSlots = new List<TimeSlot>();
            InitializeDefaultSchedule();
        }

        private void InitializeDefaultSchedule()
        {
            for (int i = 1; i <= 5; i++)
            {
                WeekSchedule[(DayOfWeek)i] = new WorkingHours
                {
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0),
                    IsWorkingDay = true
                };
            }
        }
    }
    public class Doctor : Person
    {
        public string Specialization { get; set; }
        public string LicenseNumber { get; set; }
        public int ExperienceYears { get; set; }
        public string DepartmentId { get; set; }
        public Schedule Schedule { get; set; }

        public Doctor() : base()
        {
            Schedule = new Schedule(Id);
        }

        public Doctor(string firstName, string lastName, string phone, DateTime dob,
                      string specialization, string license, int experience, string deptId)
            : base(firstName, lastName, phone, dob)
        {
            Specialization = specialization;
            LicenseNumber = license;
            ExperienceYears = experience;
            DepartmentId = deptId;
            Schedule = new Schedule(Id);
        }

        public override string GetInfo()
        {
            return $"Д-р {GetFullName()}, {Specialization}, стаж: {ExperienceYears} лет";
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


