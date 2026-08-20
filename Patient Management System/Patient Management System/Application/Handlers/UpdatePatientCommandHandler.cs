using Patient_Management_System.Application.Commands;
using Patient_Management_System.Application.Interface;

namespace Patient_Management_System.Application.Handlers
{
    public class UpdatePatientCommandHandler
    {
        private readonly IPatientReader _patientReader;
        private readonly IPatientWriter _patientWriter;

        public UpdatePatientCommandHandler(
            IPatientReader patientReader,
            IPatientWriter patientWriter)
        {
            _patientReader = patientReader;
            _patientWriter = patientWriter;
        }

        public void Handle(UpdatePatientCommand command)
        {
            var patient = _patientReader.GetPatientById(command.Id);

            if (patient == null)
            {
                return;
            }

            patient.ChangeFirstName(command.FirstName);
            patient.ChangeLastName(command.LastName);
            patient.ChangeDateOfBirth(command.DateOfBirth);

            _patientWriter.UpdatePatient(patient);
        }
    }
}