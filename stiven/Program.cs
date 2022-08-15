using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace stiven
{
    class Program
    {
        static void Main(string[] args)
        {

            var appt = new Appointment
            {
                Patient = new Patient
                {
                    Name = "Ali Stiven",
                    Email = "stivenlovera@gmail.com",
                    LastName = "Lovera Huarachi",
                },
                Time = new DateTime(2019, 03, 08, 15, 20, 19),
                Record=30
            };
            WriteLine(new AppointmentService().Create(appt));


            ReadLine();
        }
    }

    public class Patient
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class Appointment
    {
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
        public int Record { get; set; }
    }

    public class ValidationResult
    {
        public List<string> ErrorMessage { get; set; } = new List<string>();
        public bool IsValid { get { return !ErrorMessage.Any(); } }
    }
    public static class AppointmentServiceValidator
    {
        public static ValidationResult Validate(Appointment appointment)
        {
            ValidationResult validation = new ValidationResult();

            if (string.IsNullOrEmpty(appointment.Record.ToString()))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");

            if (string.IsNullOrEmpty(appointment.Patient.Name))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");

            if (string.IsNullOrEmpty(appointment.Patient.LastName))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar un apellido.");

            if (appointment.Time.Equals(DateTime.MinValue))
                validation.ErrorMessage.Add("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");

            if (!appointment.Patient.Email.Contains("@") || string.IsNullOrEmpty(appointment.Patient.Email))
                validation.ErrorMessage.Add($"La cita no puede ser agendada, debido a que debe proporcionar un email valido.");
            //Console.WriteLine(validation.IsValid.ToString(),validation.ErrorMessage.Any());
            return validation;
        }
    }
    public class AppointmentService
    {
        public string Create(Appointment appointment)
        {
            ValidationResult validation = AppointmentServiceValidator.Validate(appointment);

            return validation.IsValid ?
                $"La cita numero {appointment.Record} quedo agendada para el paciente {appointment.Patient.Name} {appointment.Patient.LastName} el dia {appointment.Time}." :
                string.Join(Environment.NewLine, validation.ErrorMessage);
        }

    }
}