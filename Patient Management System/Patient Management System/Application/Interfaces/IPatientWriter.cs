using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Application.Interface
{
    public interface IPatientWriter
    {
        Task AddPatientAsync(Patient patient);
        Task UpdatePatientAsync(Patient patient);
        Task RemovePatientAsync(Guid id);
    }
}
