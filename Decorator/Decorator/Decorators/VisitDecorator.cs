using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Interfaces;
namespace Decorator.Decorators
{
    public class VisitDecorator : IPatient
    {
        private readonly IPatient _patient;

        public VisitDecorator(IPatient patient, DateOnly visitDate)
        {
            _patient = patient;
            VisitDate = visitDate;
        }
        public Guid Id
        {
            get { return _patient.Id; }
        }
        public string FirstName
        {
            get{ return _patient.FirstName; }
        }
        public string LastName
        {
            get{ return _patient.LastName; }
        }
        public DateOnly? DateOfBirth
        {
            get{ return _patient.DateOfBirth; }
        }
        public bool HasVisit => true;
        public DateOnly VisitDate { get; }
    }
}
