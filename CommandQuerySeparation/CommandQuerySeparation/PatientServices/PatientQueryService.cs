using System;
using System.Collections.Generic;
using System.Text;

namespace CommandQuerySeparation.PatientServices
{
    internal class PatientQueryService
    {
        private readonly PatientRepository _patientRepository;
        public PatientQueryService(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Patient? GetPatientById(Guid id)
        {
            return _patientRepository.GetById(id);
        }
    }
}
