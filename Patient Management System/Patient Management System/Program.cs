using Patient_Management_System.Models;

namespace Patient_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "Jan",
                LastName = "Kowalski",
                DateOfBirth = new DateOnly(1990, 1, 1)
            };
        }
    }
}
