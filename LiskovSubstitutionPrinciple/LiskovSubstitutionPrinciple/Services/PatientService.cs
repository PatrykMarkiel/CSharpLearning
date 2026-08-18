using System;
using System.Collections.Generic;
using System.Text;
using LiskovSubstitutionPrinciple.Models;
namespace LiskovSubstitutionPrinciple.Services
{
    internal class PatientService
    {
        public void ProcessPatient(Patient patient)
        {
            Console.WriteLine($"{patient.FirstName} {patient.LastName}");
        }
    }
}
