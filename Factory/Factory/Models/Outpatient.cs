using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class Outpatient : Patient
    {
        public DateOnly? LastVisitDate { get; set; }
    }
}
