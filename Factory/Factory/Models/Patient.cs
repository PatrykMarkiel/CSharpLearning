using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public  class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}
