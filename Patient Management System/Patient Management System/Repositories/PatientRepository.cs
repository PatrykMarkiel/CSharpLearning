using Patient_Management_System.Interface;
using Patient_Management_System.Models;
namespace Patient_Management_System.Repositories
{
    public class PatientRepository : IPatientReader, IPatientWriter
    {
        private readonly List<Patient> _patient = new();
        public void AddPatient(Patient patient)
        {
            _patient.Add(patient);
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
                _patient.Remove(patient);
            }
        }
        public Patient? GetPatientById(Guid id)
        {
            return _patient.Find(p => p.Id == id);

        }
    }
}
