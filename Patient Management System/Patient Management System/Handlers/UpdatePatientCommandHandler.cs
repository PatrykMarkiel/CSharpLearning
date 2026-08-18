using Patient_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Commands;

namespace Patient_Management_System.Handlers
{
    public class UpdatePatientCommandHandler
    {
        private readonly PatientRepository _patientRepository;
        public UpdatePatientCommandHandler(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public void Handle(UpdatePatientCommand command)
        {
            var patient = _patientRepository.GetPatientById(command.Id);
            if (patient != null)
            {
                patient.FirstName = command.FirstName;
                patient.LastName = command.LastName;
                patient.DateOfBirth = command.DateOfBirth;
            }
        }
    }
}
