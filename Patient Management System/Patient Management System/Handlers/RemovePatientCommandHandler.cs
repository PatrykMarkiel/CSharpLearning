using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Commands;
using Patient_Management_System.Repositories;
using Patient_Management_System.Models;
namespace Patient_Management_System.Handlers
{
    public class RemovePatientCommandHandler
    {
        private readonly PatientsRepository _patientsRepository;
        public RemovePatientCommandHandler(PatientsRepository patientRepository)
        {
            _patientsRepository = patientRepository;
        }
        public void Handle(RemovePatientCommand command)
        {
            _patientsRepository.RemovePatient(command.Id);
        }
    }
}
