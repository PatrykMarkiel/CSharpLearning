using System;
using System.Collections.Generic;
using System.Text;

namespace CommandQueryResponsibilitySegregation.Commands
{
    public class CreatePatientCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
