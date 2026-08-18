using LiskovSubstitutionPrinciple.Interfaces;
using System;

namespace LiskovSubstitutionPrinciple.Models
{
    public class Inpatient : Patient, IDischargable
    {
        public DateOnly AdmissionDate { get; set; }
        public DateOnly? DischargeDate { get; set; }

        public void Discharge()
        {
            DischargeDate = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}