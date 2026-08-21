using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Application.Interface
{
    public interface IPatientWriter
    {
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void RemovePatient(Guid id);
    }
}
