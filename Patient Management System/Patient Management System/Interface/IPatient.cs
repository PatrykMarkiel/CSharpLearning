using Patient_Management_System.Domain.ValueObjects;

namespace Patient_Management_System.Interface
{
    public interface IPatient
    {
        Guid Id { get; }
        FirstName FirstName { get; }
        LastName LastName { get; }
        DateOnly? DateOfBirth { get; }
    }
}
