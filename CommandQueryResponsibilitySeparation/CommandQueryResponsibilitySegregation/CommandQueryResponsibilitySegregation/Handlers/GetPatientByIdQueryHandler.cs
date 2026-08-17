using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using CommandQueryResponsibilitySegregation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandQueryResponsibilitySegregation.Handlers
{
    internal class GetPatientByIdQueryHandler
    {
        private readonly PatientRepository _patientRepository;
        public GetPatientByIdQueryHandler(PatientRepository patinetRepository)
        {
            _patientRepository = patinetRepository;
        }

        public Patient? Handle(GetPatientByIdQuery query)
        {
            return _patientRepository.GetById(query.Id);
        }
    }
}
