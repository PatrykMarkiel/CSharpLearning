namespace Patient_Management_System.Application.Commands
{
    public class CreatePatientCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
