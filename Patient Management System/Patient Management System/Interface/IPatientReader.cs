using Patient_Management_System.Models;

namespace Patient_Management_System.Interface
{
    public interface IPatientReader
    {
        Patient? GetPatientById(Guid id);
    }
}