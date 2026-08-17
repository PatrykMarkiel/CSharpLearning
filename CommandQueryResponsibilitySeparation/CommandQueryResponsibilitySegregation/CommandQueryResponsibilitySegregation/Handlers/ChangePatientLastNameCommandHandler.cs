using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Repositories;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    public class ChangePatientLastNameCommandHandler
    {
        private readonly PatientRepository _patientRepository;

        public ChangePatientLastNameCommandHandler(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Guid Handle(ChangePatientLastNameCommand command)
       {
            Patient patient = _patientRepository.GetById(command.Id);
            patient.LastName = command.LastName;
            return patient.Id;
        }
    }
}

