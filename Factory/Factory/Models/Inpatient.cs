using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class Inpatient : Patient
    {
        public DateOnly AdmissionDate { get; set; }
    }
}
