using LiskovSubstitutionPrinciple.Models;
using LiskovSubstitutionPrinciple.Services;
using LiskovSubstitutionPrinciple.Interfaces;
namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "Jan",
                LastName = "Kowalski"
            };

            Patient inpatient = new Inpatient
            {
                Id = Guid.NewGuid(),
                FirstName = "Jan",
                LastName = "Paweł",
                AdmissionDate = new DateOnly(2003, 8, 18)
            };
            IDischargable dischargeable = new Inpatient
            {
                Id = Guid.NewGuid(),
                FirstName = "Marek",
                LastName = "Nowak",
                AdmissionDate = new DateOnly(2013, 2, 12)
            };

            dischargeable.Discharge();
            PatientService service = new PatientService();

            service.ProcessPatient(patient);
            service.ProcessPatient(inpatient);
            service.ProcessPatient((Patient)dischargeable);
        }
    }
}
