using System;
using System.Collections.Generic;
using System.Text;

namespace DapperLearning.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
