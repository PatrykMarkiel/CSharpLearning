using Factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public class PatientFactory
    {
        public Patient Create(PatientType type, string firstName, string lastName)
        {
            switch (type)
            {
                case PatientType.Inpatient:
                    return new Inpatient
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        AdmissionDate = DateOnly.FromDateTime(DateTime.Now)
                    };

                case PatientType.Outpatient:
                    return new Outpatient
                    {
                        FirstName = firstName,
                        LastName = lastName
                    };

                default:
                    throw new ArgumentException("Invalid patient type");
            }
        }
    }
}
