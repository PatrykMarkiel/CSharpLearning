using Patient_Management_System.Application.Interface;
using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Infrastructure.Repositories
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
            var index = _patient.FindIndex(p => p.Id == patient.Id);

            if (index != -1)
            {
                _patient[index] = patient;
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
        public IEnumerable<Patient> GetAllPatients()
        {
            return _patient;
        }
    }
}
