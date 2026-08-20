using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Patient_Management_System.Interface;
using Patient_Management_System.Models;
namespace Patient_Management_System.Domain.Decorators
{
    public class LactoseIntoleranceDecorator : IPatient
    {
        private readonly IPatient _patient;
        public LactoseIntoleranceDecorator(IPatient patient)
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
        public bool HasLactoseIntolerance = true;
    }
}
