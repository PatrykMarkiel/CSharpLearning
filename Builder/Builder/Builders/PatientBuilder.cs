using System;
using System.Collections.Generic;
using System.Text;
using Builder.Models;
namespace Builder.Builders
{

    public class PatientBuilder : IPatientBuilder
    {
        private Patient _patient = new Patient();

        public void SetId(Guid id)
        {
            _patient.Id = id;
        }
        public void SetFirstName(string firstName)
        {
            _patient.FirstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            _patient.LastName = lastName;
        }
        public void SetDateOfBirth(DateOnly? dateOfBirth)
        {
            _patient.DateOfBirth = dateOfBirth;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            _patient.PhoneNumber = phoneNumber;
        }
        public void SetEmail(string email)
        {
            _patient.Email = email;
        }
        public void SetAddress(string address)
        {
            _patient.Address = address;
        }
        public Patient Build()
        {
            Patient result = _patient;
            _patient = new Patient();

            return result;
        }
    }
}
