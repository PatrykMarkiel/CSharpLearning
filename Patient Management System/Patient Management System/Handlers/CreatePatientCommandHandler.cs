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
        private readonly PatientsRepository _patientsRepository;
        public CreatePatientCommandHandler(PatientsRepository patientRepository)
        {
            _patientsRepository = patientRepository;
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
            _patientsRepository.AddPatient(patient);
            return patient.Id;
        }
    }
}
