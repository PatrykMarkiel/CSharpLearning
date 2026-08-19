using Patient_Management_System.Commands;
using Patient_Management_System.Interface;

namespace Patient_Management_System.Handlers
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

            if (command.FirstName != null)
            {
                patient.FirstName = command.FirstName;
            }

            if (command.LastName != null)
            {
                patient.LastName = command.LastName;
            }

            if (command.DateOfBirth.HasValue)
            {
                patient.DateOfBirth = command.DateOfBirth;
            }

            _patientWriter.UpdatePatient(patient);
        }
    }
}