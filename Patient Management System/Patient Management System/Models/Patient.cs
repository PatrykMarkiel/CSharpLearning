using Patient_Management_System.Interface;

namespace Patient_Management_System.Models
{

     public class Patient : IPatient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
