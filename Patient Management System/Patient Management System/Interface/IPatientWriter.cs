using Patient_Management_System.Models;

namespace Patient_Management_System.Interface
{
    public interface IPatientWriter
    {
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void RemovePatient(Guid id);
    }
}
