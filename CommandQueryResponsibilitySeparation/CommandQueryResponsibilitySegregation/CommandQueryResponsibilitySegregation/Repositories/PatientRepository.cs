using System;
using System.Collections.Generic;
using System.Text;
using CommandQueryResponsibilitySegregation.Models;
namespace CommandQueryResponsibilitySegregation.Repositories
{
    public class PatientRepository
    {
        private readonly List<Patient> _patients = new();
        public void Add(Patient patient)
        {
            _patients.Add(patient);
        }
        public Patient? GetById(Guid id)
        {
            return _patients.Find(p => p.Id == id);
        }
    }
}
