using Patient_Management_System.Commands;
using Patient_Management_System.Interface;
using Patient_Management_System.Models;

namespace Patient_Management_System.Handlers
{
    internal class CreatePatientCommandHandler
    {
        private readonly IPatientWriter _patientWriter;
        public CreatePatientCommandHandler(IPatientWriter patientWriter)
        {
            _patientWriter = patientWriter;
        }
        public Guid Handle(CreatePatientCommand command)
        {
            var patient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                DateOfBirth = command.DateOfBirth
            };
            _patientWriter.AddPatient(patient);
            return patient.Id;
        }
    }
}
