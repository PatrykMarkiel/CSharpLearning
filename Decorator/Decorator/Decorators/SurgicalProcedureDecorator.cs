
using Decorator.Interfaces;
using Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    public class SurgicalProcedureDecorator : IPatient
    {
        private readonly IPatient _patient;
        public SurgicalProcedureDecorator(IPatient patient)
        {
            _patient = patient;
        }
        public Guid Id
        {
            get { return _patient.Id; }
        }
        public string FirstName
        {
            get { return _patient.FirstName; }
        }
        public string LastName
        {
            get { return _patient.LastName; }
        }
        public DateOnly? DateOfBirth
        {
            get { return _patient.DateOfBirth; }
        }
        public bool HasSurgicalProcedure => true;
    }
}
