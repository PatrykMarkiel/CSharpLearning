using System;
using System.Collections.Generic;
using System.Text;

namespace CommandQuerySeparation
{
    internal class Patient
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
