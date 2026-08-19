using Patient_Management_System.Commands;
using Patient_Management_System.Handlers;
using Patient_Management_System.Models;
using Patient_Management_System.Queries;
using Patient_Management_System.Repositories;

namespace Patient_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientsRepository patientsRepository = new PatientsRepository();

            CreatePatientCommandHandler createPatientCommandHandler = new CreatePatientCommandHandler(patientsRepository);
            UpdatePatientCommandHandler updatePatientCommandHandler = new UpdatePatientCommandHandler(patientsRepository);
            RemovePatientCommandHandler removePatientCommandHandler = new RemovePatientCommandHandler(patientsRepository);
            GetPatientByIdQueryHandler getPatientByIdQueryHandler = new GetPatientByIdQueryHandler(patientsRepository);

            CreatePatientCommand createPatientCommand = new CreatePatientCommand
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                DateOfBirth = new DateOnly(1990, 1, 1)
            };

            Guid patientId = createPatientCommandHandler.Handle(createPatientCommand);

            var patient = getPatientByIdQueryHandler.Handle(
                new GetPatientByIdQuery
                {
                    Id = patientId
                });

            Console.WriteLine($"ID: {patient.Id}");
            Console.WriteLine($"First name: {patient.FirstName}");
            Console.WriteLine($"Last name: {patient.LastName}");
            Console.WriteLine($"Date of birth: {patient.DateOfBirth}");

            UpdatePatientCommand updatePatientCommand = new UpdatePatientCommand
            {
                Id  = patientId,
                LastName = "Paweł",
            };
            updatePatientCommandHandler.Handle(updatePatientCommand);

            patient = getPatientByIdQueryHandler.Handle(
                new GetPatientByIdQuery
                {
                    Id = patientId
                });

            Console.WriteLine($"ID: {patient.Id}");
            Console.WriteLine($"First name: {patient.FirstName}");
            Console.WriteLine($"Last name: {patient.LastName}");
            Console.WriteLine($"Date of birth: {patient.DateOfBirth}");


            RemovePatientCommand removePatientCommand = new RemovePatientCommand
            {
                Id = patientId
            };

            removePatientCommandHandler.Handle(removePatientCommand);

            Console.WriteLine($"Patient: {patient.Id} removed");
        }
    }
}
