using Patient_Management_System.Application.Interface;
using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Infrastructure.Repositories
{
    public class PatientRepository : IPatientReader, IPatientWriter
    {
        private readonly List<Patient> _patient = new();
        public Task AddPatientAsync(Patient patient)
        {
            _patient.Add(patient);
            return Task.CompletedTask;
        }
        public Task UpdatePatientAsync(Patient patient)
        {
            var index = _patient.FindIndex(p => p.Id == patient.Id);

            if (index != -1)
            {
                _patient[index] = patient;
            }
            return Task.CompletedTask;
        }

        public async Task RemovePatientAsync(Guid id)
        {
            var patient = await GetPatientByIdAsync(id);
            if (patient != null)
            {
                _patient.Remove(patient);
            }
        }
        public Task<Patient?> GetPatientByIdAsync(Guid id)
        {
            var patient =  _patient.Find(p => p.Id == id);
            return Task.FromResult(patient);

        }
        public Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return Task.FromResult<IEnumerable<Patient>>(_patient);
        }
    }
}
