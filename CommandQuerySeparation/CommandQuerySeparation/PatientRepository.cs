using System;
using System.Collections.Generic;
using System.Text;
namespace CommandQuerySeparation
{
    internal class PatientRepository
    {
        private readonly List<Patient> _patients = new();
        public void Add(Patient patient)
        {
            _patients.Add(patient);
        }
        public Patient? GetById(Guid id)
        {
            return _patients.FirstOrDefault(p => p.Id == id);
        }
    }
}
