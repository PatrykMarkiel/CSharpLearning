using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public class Patient : IPatient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
