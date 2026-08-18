using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Queries;
using Patient_Management_System.Repositories;
using Patient_Management_System.Models;
namespace Patient_Management_System.Handlers
{
    internal class GetPatientByIdQueryHandler
    {
        private readonly PatientRepository _patientRepository;
        public GetPatientByIdQueryHandler(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Patient? Handle(GetPatientByIdQuery query)
        {
            return _patientRepository.GetPatientById(query.Id);
        }
    }
}
