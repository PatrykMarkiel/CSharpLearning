using Patient_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Commands;
using Patient_Management_System.Models;
namespace Patient_Management_System.Handlers
{
    internal class CreatePatientCommandHandler
    {
        private readonly PatientRepository _patientRepository;
        public CreatePatientCommandHandler(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public void Handle(CreatePatientCommand command)
        {
            var patient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                DateOfBirth = command.DateOfBirth
            };
            _patientRepository.AddPatient(patient);
        }
    }
}
