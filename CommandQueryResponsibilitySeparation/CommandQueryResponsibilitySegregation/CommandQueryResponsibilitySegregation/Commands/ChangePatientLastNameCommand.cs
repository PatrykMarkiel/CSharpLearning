using System;
using System.Collections.Generic;
using System.Text;

namespace CommandQueryResponsibilitySegregation.Commands
{
    public class ChangePatientLastNameCommand
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
    }
}
