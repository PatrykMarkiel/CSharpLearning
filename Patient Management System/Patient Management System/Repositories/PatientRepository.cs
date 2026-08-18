using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Patient_Management_System.Models;
namespace Patient_Management_System.Repositories
{
    public class PatientRepository
    {
        private readonly List<Patient> _patient = new();
        public void AddPatient(Patient patient)
        {
            _patient.Add(patient);
        }

        public Patient? GetPatientById(Guid id)
        {
            return _patient.Find(p => p.Id == id);
        }
    }
}
