using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Application.Interface
{
    public interface IPatientReader
    {
        Task<Patient?> GetPatientByIdAsync(Guid id);
        Task<IEnumerable<Patient>> GetAllPatientsAsync();
    }
}