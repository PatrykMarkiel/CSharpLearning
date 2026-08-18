using System;
using System.Collections.Generic;
using System.Text;
using Builder.Models;
namespace Builder.Builders
{
    public interface IPatientBuilder
    {
        void SetId(Guid id);
        void SetFirstName(string firstName);
        void SetLastName(string lastName);
        void SetDateOfBirth(DateOnly? dateOfBirth);
        void SetPhoneNumber(string phoneNumber);
        void SetEmail(string email);
        void SetAddress(string address);
        Patient Build();
    }
}
