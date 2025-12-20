using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml;
using JsonFormatting = Newtonsoft.Json.Formatting;
using course_medapp.Forms;


namespace course_medapp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); 
        }
    }
        public abstract class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        protected Person()
        {
            Id = Guid.NewGuid().ToString();
        }

        protected Person(string firstName, string lastName, string phone, DateTime dob, string middleName = null)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phone;
            DateOfBirth = dob;
        }

        public string GetFullName()
        {
            if (string.IsNullOrWhiteSpace(MiddleName))
                return $"{LastName} {FirstName}";
            else
                return $"{LastName} {FirstName} {MiddleName}";
        }
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

        public Patient(string firstName, string lastName, string phone, DateTime dob, string address, string insurance, string middleName = null)
            : base(firstName, lastName, phone, dob, middleName)
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
                      string specialization, string license, int experience, string deptId, string middleName = null)
            : base(firstName, lastName, phone, dob, middleName)
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
    public class DataManager
    {
        private static DataManager _instance;
        private static readonly object _lock = new object();

        private readonly ISaveLoadService _saveLoadService;
        private ApplicationData _data;

        private const string DATA_FILE = "medical_system_data.json";
        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new DataManager();
                    }
                }
                return _instance;
            }
        }
        private DataManager()
        {
            _saveLoadService = new JsonSaveLoadService();
            LoadAllData();
        }
        public IReadOnlyList<Patient> Patients => _data.Patients.AsReadOnly();
        public IReadOnlyList<Doctor> Doctors => _data.Doctors.AsReadOnly();
        public IReadOnlyList<Appointment> Appointments => _data.Appointments.AsReadOnly();
        public IReadOnlyList<Department> Departments => _data.Departments.AsReadOnly();


        // методы для работы с пациентами
        public void AddPatient(Patient patient)
        {
            if (patient == null)
                throw new ArgumentNullException(nameof(patient));

            _data.Patients.Add(patient);
            SaveAllData();
        }

        public void UpdatePatient(Patient patient)
        {
            var existing = _data.Patients.FirstOrDefault(p => p.Id == patient.Id);
            if (existing == null)
                throw new InvalidOperationException("Пациент не найден");

            int index = _data.Patients.IndexOf(existing);
            _data.Patients[index] = patient;
            SaveAllData();
        }
        public void DeletePatient(string patientId)
        {
            var patient = _data.Patients.FirstOrDefault(p => p.Id == patientId);
            if (patient == null)
                throw new InvalidOperationException("Пациент не найден");

            // отмена всех будущих записей пациента
            var futureAppointments = _data.Appointments
                .Where(a => a.PatientId == patientId &&
                           a.Status == AppointmentStatus.Scheduled &&
                           a.AppointmentDateTime > DateTime.Now)
                .ToList();

            foreach (var apt in futureAppointments)
            {
                apt.Status = AppointmentStatus.Cancelled;
            }

            _data.Patients.Remove(patient);
            SaveAllData();
        }
        public Patient GetPatientById(string id)
        {
            return _data.Patients.FirstOrDefault(p => p.Id == id);
        }

        public List<Patient> SearchPatients(string searchText)
        {
            searchText = searchText.ToLower();
            return _data.Patients
                .Where(p => p.FirstName.ToLower().Contains(searchText) ||
                           p.LastName.ToLower().Contains(searchText) ||
                           p.MedicalCardNumber.ToLower().Contains(searchText))
                .ToList();
        }
        // методы для работы с врачами
        public void AddDoctor(Doctor doctor)
        {
            if (doctor == null)
                throw new ArgumentNullException(nameof(doctor));

            _data.Doctors.Add(doctor);
            SaveAllData();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            var existing = _data.Doctors.FirstOrDefault(d => d.Id == doctor.Id);
            if (existing == null)
                throw new InvalidOperationException("Врач не найден");

            int index = _data.Doctors.IndexOf(existing);
            _data.Doctors[index] = doctor;
            SaveAllData();
        }

        public void DeleteDoctor(string doctorId)
        {
            var doctor = _data.Doctors.FirstOrDefault(d => d.Id == doctorId);
            if (doctor == null)
                throw new InvalidOperationException("Врач не найден");

            // отмена всех будущих записей к врачу
            var futureAppointments = _data.Appointments
                .Where(a => a.DoctorId == doctorId &&
                           a.Status == AppointmentStatus.Scheduled &&
                           a.AppointmentDateTime > DateTime.Now)
                .ToList();

            foreach (var apt in futureAppointments)
            {
                apt.Status = AppointmentStatus.Cancelled;
            }

            _data.Doctors.Remove(doctor);
            SaveAllData();
        }
        public Doctor GetDoctorById(string id)
        {
            return _data.Doctors.FirstOrDefault(d => d.Id == id);
        }

        public List<Doctor> GetDoctorsBySpecialization(string specialization)
        {
            return _data.Doctors
                .Where(d => d.Specialization.Equals(specialization, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<string> GetAllSpecializations()
        {
            return _data.Doctors
                .Select(d => d.Specialization)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }

        // методы для работы с записями
        public void AddAppointment(Appointment appointment)
        {
            if (appointment == null)
                throw new ArgumentNullException(nameof(appointment));

            // Проверяем, нет ли конфликта времени
            bool hasConflict = _data.Appointments.Any(a =>
                a.DoctorId == appointment.DoctorId &&
                a.Status == AppointmentStatus.Scheduled &&
                a.AppointmentDateTime < appointment.AppointmentDateTime.AddMinutes(appointment.DurationMinutes) &&
                appointment.AppointmentDateTime < a.AppointmentDateTime.AddMinutes(a.DurationMinutes));

            if (hasConflict)
                throw new InvalidOperationException("Это время уже занято");

            _data.Appointments.Add(appointment);
            SaveAllData();
        }
        public void CancelAppointment(string appointmentId)
        {
            var appointment = _data.Appointments.FirstOrDefault(a => a.Id == appointmentId);
            if (appointment == null)
                throw new InvalidOperationException("Запись не найдена");

            appointment.Cancel();
            SaveAllData();
        }

        public void CompleteAppointment(string appointmentId)
        {
            var appointment = _data.Appointments.FirstOrDefault(a => a.Id == appointmentId);
            if (appointment == null)
                throw new InvalidOperationException("Запись не найдена");

            appointment.Complete();
            SaveAllData();
        }

        public List<Appointment> GetPatientAppointments(string patientId)
        {
            return _data.Appointments
                .Where(a => a.PatientId == patientId)
                .OrderByDescending(a => a.AppointmentDateTime)
                .ToList();
        }

        public List<Appointment> GetDoctorAppointments(string doctorId, DateTime? date = null)
        {
            var query = _data.Appointments.Where(a => a.DoctorId == doctorId);

            if (date.HasValue)
            {
                var startDate = date.Value.Date;
                var endDate = startDate.AddDays(1);
                query = query.Where(a => a.AppointmentDateTime >= startDate && a.AppointmentDateTime < endDate);
            }

            return query.OrderBy(a => a.AppointmentDateTime).ToList();
        }

        public List<Appointment> GetUpcomingAppointments(int daysAhead = 7)
        {
            var startDate = DateTime.Now;
            var endDate = startDate.AddDays(daysAhead);

            return _data.Appointments
                .Where(a => a.Status == AppointmentStatus.Scheduled &&
                           a.AppointmentDateTime >= startDate &&
                           a.AppointmentDateTime <= endDate)
                .OrderBy(a => a.AppointmentDateTime)
                .ToList();
        }

        // методы для работы с отделениями
        public void AddDepartment(Department department)
        {
            if (department == null)
                throw new ArgumentNullException(nameof(department));

            _data.Departments.Add(department);
            SaveAllData();
        }
        public void UpdateDepartment(Department department)
        {
            var existing = _data.Departments.FirstOrDefault(d => d.Id == department.Id);
            if (existing == null)
                throw new InvalidOperationException("Отделение не найдено");

            int index = _data.Departments.IndexOf(existing);
            _data.Departments[index] = department;
            SaveAllData();
        }
        public void DeleteDepartment(string departmentId)
        {
            var department = _data.Departments.FirstOrDefault(d => d.Id == departmentId);
            if (department == null)
                throw new InvalidOperationException("Отделение не найдено");

            _data.Departments.Remove(department);
            SaveAllData();
        }
        public Department GetDepartmentById(string id)
        {
            return _data.Departments.FirstOrDefault(d => d.Id == id);
        }

        // методы сохранения и загрузки
        private void SaveAllData()
        {
            try
            {
                _saveLoadService.SaveData(_data, DATA_FILE);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Не удалось сохранить данные: {ex.Message}", ex);
            }
        }
        private void LoadAllData()
        {
            try
            {
                _data = _saveLoadService.LoadData<ApplicationData>(DATA_FILE);

                if (_data == null)
                    _data = new ApplicationData();

                // Создаём тестовые данные, если база пустая
                if (!_data.Patients.Any() && !_data.Doctors.Any())
                {
                    InitializeTestData();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Не удалось загрузить данные: {ex.Message}", ex);
            }
        }

        private void InitializeTestData()
        {
            // отделения
            var cardiology = new Department("Кардиология", "Корпус А, 2 этаж", "123-45-67");
            var neurology = new Department("Неврология", "Корпус Б, 3 этаж", "123-45-68");
            var therapy = new Department("Терапия", "Корпус А, 1 этаж", "123-45-69");

            _data.Departments.AddRange(new[] { cardiology, neurology, therapy });

            // врачи
            var doctor1 = new Doctor("Иван", "Петров", "+7-900-123-45-67",
             new DateTime(1975, 5, 15), "Кардиолог", "LIC-12345", 20, cardiology.Id);

            var doctor2 = new Doctor("Мария", "Сидорова", "+7-900-123-45-68",
                new DateTime(1980, 8, 22), "Невролог", "LIC-12346", 15, neurology.Id);

            var doctor3 = new Doctor("Сергей", "Иванов", "+7-900-123-45-69",
                new DateTime(1985, 3, 10), "Терапевт", "LIC-12347", 10, therapy.Id);

            _data.Doctors.AddRange(new[] { doctor1, doctor2, doctor3 });
            cardiology.AddDoctor(doctor1.Id);
            neurology.AddDoctor(doctor2.Id);
            therapy.AddDoctor(doctor3.Id);

            // пациенты
            var patient1 = new Patient("Алексей", "Смирнов", "+7-900-111-22-33",
                new DateTime(1990, 1, 15), "ул. Ленина, д. 10", "INS-001");

            var patient2 = new Patient("Елена", "Кузнецова", "+7-900-111-22-34",
                new DateTime(1985, 6, 20), "ул. Пушкина, д. 20", "INS-002");

            _data.Patients.AddRange(new[] { patient1, patient2 });

            SaveAllData();
        }
        public void ResetToTestData()
        {
            _data = new ApplicationData();
            InitializeTestData();
        }
    }
}


