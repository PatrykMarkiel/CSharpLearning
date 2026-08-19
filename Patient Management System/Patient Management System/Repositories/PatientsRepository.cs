using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Patient_Management_System.Models;
namespace Patient_Management_System.Repositories
{
    public class PatientsRepository
    {
        private readonly List<Patient> _patients = new();
        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
        }
        public void UpdatePatient(Patient patient)
        {
            var existingPatient = GetPatientById(patient.Id);
            if (existingPatient != null)
            {
                existingPatient.FirstName = patient.FirstName;
                existingPatient.LastName = patient.LastName;
                existingPatient.DateOfBirth = patient.DateOfBirth;
            }
        }
        public void RemovePatient(Guid id)
        {
            var patient = GetPatientById(id);
            if (patient != null)
            {
                _patients.Remove(patient);
            }
        }
        public Patient? GetPatientById(Guid id)
        {
            return _patients.Find(p => p.Id == id);

        }
    }
}
