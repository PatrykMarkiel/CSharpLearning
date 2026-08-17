using System;
using System.Collections.Generic;

namespace CommandQuerySeparation.PatientServices
{
    internal class PatientCommandService
    {
        private readonly PatientRepository _patientRepository;
        public PatientCommandService(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public void CreatePatient(Patient patient)
        {
            _patientRepository.Add(patient);
        }
    }
}
