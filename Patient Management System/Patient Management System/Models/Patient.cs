using Patient_Management_System.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
