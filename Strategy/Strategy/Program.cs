using Strategy.Models;
using Strategy.Services;
using Strategy.Strategies;

namespace Strategy
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

            PatientPriorityService normalService =
                new PatientPriorityService(new NormalPriorityStrategy());

            PatientPriorityService emergencyService =
                new PatientPriorityService(new EmergencyPriorityStrategy());

            PatientPriorityService elderlyService =
                new PatientPriorityService(new ElderlyPriorityStrategy());

            Console.WriteLine(normalService.GetPriority(patient));

            Console.WriteLine(emergencyService.GetPriority(patient));

            Console.WriteLine(elderlyService.GetPriority(patient));
        }
    }
}
