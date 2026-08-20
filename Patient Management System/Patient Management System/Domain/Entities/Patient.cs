using Patient_Management_System.Domain.ValueObjects;
using Patient_Management_System.Application.Interface;

namespace Patient_Management_System.Domain.Entities
{

     public class Patient
    {
        public Guid Id { get; private set; }
        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        public DateOnly? DateOfBirth { get; private set; }
        public Patient(
        string firstName,
        string lastName,
        DateOnly? dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("First name can not be empty");
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Last name can not be empty");
            if (dateOfBirth.HasValue &&
                dateOfBirth.Value > DateOnly.FromDateTime(DateTime.Today))
            {
                throw new ArgumentException("Date of birth cannot be in the future.");
            }

            Id = Guid.NewGuid();
            FirstName = new FirstName(firstName);
            LastName = new LastName(lastName);
            DateOfBirth = dateOfBirth;

        }
        public void ChangeFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name can not be empty.");

            FirstName = new FirstName(firstName);
        }

        public void ChangeLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name can not be empty.");

            LastName = new LastName(lastName);
        }

        public void ChangeDateOfBirth(DateOnly? dateOfBirth)
        {
            if (dateOfBirth.HasValue &&
                dateOfBirth.Value > DateOnly.FromDateTime(DateTime.Today))
            {
                throw new ArgumentException("Date of birth can not be in the future.");
            }

            DateOfBirth = dateOfBirth;
        }
    }
}
