using DapperLearning.Models;
using DapperLearning.Raw;

namespace DapperLearning;

internal class Program
{
    static async Task Main()
    {
        const string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=DapperLearning;Trusted_Connection=True;TrustServerCertificate=True;";

        var repository = new PatientRepository(connectionString);

        var patient = new Patient
        {
            Id = Guid.NewGuid(),
            FirstName = "Jan",
            LastName = "Kowalski"
        };

        await repository.AddAsync(patient);

        patient.FirstName = "Jan";
        patient.LastName = "Paweł";

        await repository.UpdateAsync(patient);

        var patients = await repository.GetAllAsync();

        foreach (var currentPatient in patients)
        {
            Console.WriteLine($"ID: {currentPatient.Id}");
            Console.WriteLine($"First name: {currentPatient.FirstName}");
            Console.WriteLine($"Last name: {currentPatient.LastName}");
            Console.WriteLine();
        }

        await repository.GetByIdAsync(patient.Id);
        await repository.DeleteAsync(patient.Id);
    }
}