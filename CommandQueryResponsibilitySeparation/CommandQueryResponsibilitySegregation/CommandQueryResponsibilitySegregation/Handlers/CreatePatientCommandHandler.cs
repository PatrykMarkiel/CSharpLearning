using System;
using System.Collections.Generic;
using System.Text;
using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Repositories;
namespace CommandQueryResponsibilitySegregation.Handlers
{
    internal class CreatePatientCommandHandler
    {
        private readonly PatientRepository _patientRepository;
        public CreatePatientCommandHandler(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
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
            _patientRepository.Add(patient);
            return patient.Id;
        }
    }
}
