using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Management_System.Commands
{
    public class UpdatePatientDateOfBirthCommand
    {
        public Guid Id { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
