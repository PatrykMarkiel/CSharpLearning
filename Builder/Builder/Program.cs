using Builder.Builders;
using Builder.Directors;
using Builder.Models;
namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPatientBuilder builder = new PatientBuilder();
            PatientDirector director = new PatientDirector(builder);

            Patient basicPatient = director.BuildBasicPatient();
            Patient completePatient = director.BuildCompletePatient();

            Console.WriteLine(basicPatient.FirstName);
            Console.WriteLine(basicPatient.LastName);
            Console.WriteLine();
            foreach (var property in completePatient.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(completePatient)}");
            }
        }
    }
}
