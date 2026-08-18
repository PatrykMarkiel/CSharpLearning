using Factory.Factories;
using Factory.Models;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientFactory factory = new PatientFactory();
            Patient inpatient = factory.Create(PatientType.Inpatient, "Jan", "Kowalski");
            Patient outpatient = factory.Create(PatientType.Outpatient, "Jan", "Paweł");
            Console.WriteLine($"{inpatient.FirstName} {inpatient.LastName}");
            Console.WriteLine($"{outpatient.FirstName} {outpatient.LastName}");
        }
    }
}
