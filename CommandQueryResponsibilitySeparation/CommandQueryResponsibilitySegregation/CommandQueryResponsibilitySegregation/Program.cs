using CommandQueryResponsibilitySegregation.Commands;
using CommandQueryResponsibilitySegregation.Handlers;
using CommandQueryResponsibilitySegregation.Models;
using CommandQueryResponsibilitySegregation.Queries;
using CommandQueryResponsibilitySegregation.Repositories;

namespace CommandQueryResponsibilitySegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientRepository patientRepository = new PatientRepository();

            CreatePatientCommandHandler createPatientCommandHandler =
                new CreatePatientCommandHandler(patientRepository);

            ChangePatientLastNameCommandHandler changePatientLastNameHandler =
                new ChangePatientLastNameCommandHandler(patientRepository);

            GetPatientByIdQueryHandler getPatientByIdQueryHandler =
                new GetPatientByIdQueryHandler(patientRepository);

            CreatePatientCommand createPatientCommand = new CreatePatientCommand
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                DateOfBirth = new DateOnly(1990, 1, 1)
            };

            Guid patientId = createPatientCommandHandler.Handle(createPatientCommand);

            ChangePatientLastNameCommand changeCommand = new ChangePatientLastNameCommand
            {
                Id = patientId,
                LastName = "Nowak"
            };

            changePatientLastNameHandler.Handle(changeCommand);

            GetPatientByIdQuery query = new GetPatientByIdQuery
            {
                Id = patientId
            };

            Patient? patient = getPatientByIdQueryHandler.Handle(query);

            if (patient != null)
            {
                Console.WriteLine($"{patient.FirstName} {patient.LastName}");
            }
        }
    }
}