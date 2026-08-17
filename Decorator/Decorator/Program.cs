using Decorator.Decorators;
using Decorator.Interfaces;
using Decorator.Models;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "Jan",
                LastName = "Kowalski",
                DateOfBirth = new DateOnly(1990, 1, 1)
            };
            VisitDecorator patientWithVisit = new VisitDecorator(patient, new DateOnly(2026, 8, 17));

            BloodTestDecorator patientWithBloodTest = new BloodTestDecorator(patientWithVisit);
            Console.WriteLine(patientWithVisit.FirstName);
            Console.WriteLine(patientWithVisit.HasVisit);
            Console.WriteLine(patientWithBloodTest.HasBloodTest);
        }
    }
}
