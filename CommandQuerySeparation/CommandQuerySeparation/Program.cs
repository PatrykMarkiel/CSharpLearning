using CommandQuerySeparation;
using CommandQuerySeparation.PatientServices;

public class Program
{
    static void Main()
    {
        PatientRepository repository = new PatientRepository();
        PatientCommandService commandService = new PatientCommandService(repository);
        PatientQueryService queryService = new PatientQueryService(repository);

        Patient patient = new Patient
        {
            Id = Guid.NewGuid(),
            FirstName = "Jan",
            LastName = "Kowalski",
            BirthDate = new DateOnly(1990, 1, 1)
        };
        commandService.CreatePatient(patient);
        Patient foundPatient = queryService.GetPatientById(patient.Id);
        Console.WriteLine($"Patient: {foundPatient.FirstName} {foundPatient.LastName}");
    }
}