using Patient_Management_System.Domain.Entities;
using Patient_Management_System.Application.Interface;
using Patient_Management_System.Application.Commands;

namespace Patient_Management_System.Application.Handlers
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
            var patient = new Patient(
                command.FirstName,
                command.LastName,
                command.DateOfBirth);

            _patientWriter.AddPatient(patient);
            return patient.Id;
        }
    }
}
