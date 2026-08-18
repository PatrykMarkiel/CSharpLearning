using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Management_System.Commands
{
    public class UpdatePatientCommand
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }

    }
}
