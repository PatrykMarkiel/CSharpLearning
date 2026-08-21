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

        public async Task Handle(UpdatePatientCommand command)
        {
            var patient = await _patientReader.GetPatientByIdAsync(command.Id);

            if (patient == null)
            {
                return;
            }

            if (command.FirstName != null)
            {
                patient.ChangeFirstName(command.FirstName);
            }

            if (command.LastName != null)
            {
                patient.ChangeLastName(command.LastName);
            }

            if (command.DateOfBirth.HasValue)
            {
                patient.ChangeDateOfBirth(command.DateOfBirth);
            }

            await _patientWriter.UpdatePatientAsync(patient);
        }
    }
}