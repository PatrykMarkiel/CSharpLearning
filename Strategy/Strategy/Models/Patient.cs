using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
