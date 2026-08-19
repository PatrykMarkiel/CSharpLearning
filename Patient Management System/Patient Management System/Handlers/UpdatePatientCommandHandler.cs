using Patient_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Commands;


namespace Patient_Management_System.Handlers
{
    public class UpdatePatientCommandHandler
    {
        private readonly PatientsRepository _patientsRepository;

        public UpdatePatientCommandHandler(PatientsRepository patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }

        public void Handle(UpdatePatientCommand command)
        {
            var patient = _patientsRepository.GetPatientById(command.Id);

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
        }
    }
}