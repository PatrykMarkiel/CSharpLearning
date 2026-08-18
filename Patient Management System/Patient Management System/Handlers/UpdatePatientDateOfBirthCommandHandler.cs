using Patient_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Commands;

namespace Patient_Management_System.Handlers
{
    public class UpdatePatientDateOfBirthCommandHandler
    {
        private readonly PatientRepository _patientRepository;
        public UpdatePatientDateOfBirthCommandHandler(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public void Handle(UpdatePatientDateOfBirthCommand command)
        {
            var patient = _patientRepository.GetPatientById(command.Id);
            if (patient != null)
            {
                patient.DateOfBirth = command.DateOfBirth;
            }
        }
    }
}
