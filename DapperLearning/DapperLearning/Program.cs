using DapperLearning.Dapper;
using DapperLearning.Models;

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

        var patients = await repository.GetAllAsync();

        foreach (var currentPatient in patients)
        {
            Console.WriteLine(
                $"{currentPatient.Id}\t{currentPatient.FirstName}\t{currentPatient.LastName}");
        }

        var foundPatient = await repository.GetByIdAsync(patient.Id);

        Console.WriteLine();
        Console.WriteLine($"Found: {foundPatient?.FirstName} {foundPatient?.LastName}");

        patient.FirstName = "Jan";
        patient.LastName = "Paweł";

        await repository.UpdateAsync(patient);

        foundPatient = await repository.GetByIdAsync(patient.Id);

        Console.WriteLine(
            $"Updated: {foundPatient?.FirstName} {foundPatient?.LastName}");

        await repository.DeleteAsync(patient.Id);

        Console.WriteLine("Patient deleted.");
    }
}