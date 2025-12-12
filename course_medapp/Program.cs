using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml;
using JsonFormatting = Newtonsoft.Json.Formatting;


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
        public void SetWorkingHours(DayOfWeek day, TimeSpan start, TimeSpan end)
        {
            if (!WeekSchedule.ContainsKey(day))
                WeekSchedule[day] = new WorkingHours();

            WeekSchedule[day].StartTime = start;
            WeekSchedule[day].EndTime = end;
            WeekSchedule[day].IsWorkingDay = true;
        }
        public bool IsWorkingDay(DateTime date)
        {
            return WeekSchedule.ContainsKey(date.DayOfWeek) &&
                   WeekSchedule[date.DayOfWeek].IsWorkingDay;
        }
        public List<TimeSlot> GenerateAvailableSlots(DateTime date, List<Appointment> existingAppointments, int slotDuration = 30)
        {
            var slots = new List<TimeSlot>();

            if (!IsWorkingDay(date))
                return slots;

            var workHours = WeekSchedule[date.DayOfWeek];
            var currentTime = workHours.StartTime;

            while (currentTime.Add(TimeSpan.FromMinutes(slotDuration)) <= workHours.EndTime)
            {
                var slotDateTime = date.Date.Add(currentTime);

                bool isOccupied = existingAppointments.Any(a =>
                    a.DoctorId == DoctorId &&
                    a.Status == AppointmentStatus.Scheduled &&
                    a.AppointmentDateTime <= slotDateTime &&
                    slotDateTime < a.AppointmentDateTime.AddMinutes(a.DurationMinutes));

                slots.Add(new TimeSlot
                {
                    DateTime = slotDateTime,
                    IsAvailable = !isOccupied && slotDateTime > DateTime.Now
                });

                currentTime = currentTime.Add(TimeSpan.FromMinutes(slotDuration));
            }

            return slots;
        }
    }
    public class Department
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> DoctorIds { get; set; }

        public Department()
        {
            Id = Guid.NewGuid().ToString();
            DoctorIds = new List<string>();
        }

        public Department(string name, string location, string phone)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Location = location;
            PhoneNumber = phone;
            DoctorIds = new List<string>();
        }

        public void AddDoctor(string doctorId)
        {
            if (!DoctorIds.Contains(doctorId))
                DoctorIds.Add(doctorId);
        }

        public void RemoveDoctor(string doctorId)
        {
            DoctorIds.Remove(doctorId);
        }
    }
}

namespace course_medapp.Services
{
    public interface ISaveLoadService
    {
        void SaveData<T>(T data, string fileName);
        T LoadData<T>(string fileName) where T : class, new();
        bool FileExists(string fileName);
    }

    public class JsonSaveLoadService : ISaveLoadService
    {
        private readonly string _dataDirectory;
        private readonly JsonSerializerSettings _settings;
        public JsonSaveLoadService(string dataDirectory = "Data")
        {
            _dataDirectory = dataDirectory;

            _settings = new JsonSerializerSettings
            {
                Formatting = JsonFormatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                TypeNameHandling = TypeNameHandling.Auto
            };
            if (!Directory.Exists(_dataDirectory))
                Directory.CreateDirectory(_dataDirectory);
        }
        public void SaveData<T>(T data, string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);
                string jsonData = JsonConvert.SerializeObject(data, _settings);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                throw new IOException($"Ошибка сохранения данных: {ex.Message}", ex);
            }
        }
        public T LoadData<T>(string fileName) where T : class, new()
        {
            try
            {
                string filePath = Path.Combine(_dataDirectory, fileName);

                if (!File.Exists(filePath))
                    return new T();

                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(jsonData, _settings) ?? new T();
            }
            catch (Exception ex)
            {
                throw new IOException($"Ошибка загрузки данных: {ex.Message}", ex);
            }
        }
        public bool FileExists(string fileName)
        {
            string filePath = Path.Combine(_dataDirectory, fileName);
            return File.Exists(filePath);
        }
    }
    public class ApplicationData
    {
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Department> Departments { get; set; }

        public ApplicationData()
        {
            Patients = new List<Patient>();
            Doctors = new List<Doctor>();
            Appointments = new List<Appointment>();
            Departments = new List<Department>();
        }
    }
}


