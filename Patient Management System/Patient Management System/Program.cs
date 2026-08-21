using Patient_Management_System.Application.Commands;
using Patient_Management_System.Application.Handlers;
using Patient_Management_System.Application.Interface;
using Patient_Management_System.Application.Queries;
using Patient_Management_System.Infrastructure.Repositories;

namespace Patient_Management_System
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            PatientRepository patientRepository = new PatientRepository();
            IPatientReader patientReader = patientRepository;
            IPatientWriter patientWriter = patientRepository;

            CreatePatientCommandHandler createPatientCommandHandler = new CreatePatientCommandHandler(patientWriter);
            UpdatePatientCommandHandler updatePatientCommandHandler = new UpdatePatientCommandHandler(patientReader, patientWriter);
            RemovePatientCommandHandler removePatientCommandHandler = new RemovePatientCommandHandler(patientWriter);
            GetPatientByIdQueryHandler getPatientByIdQueryHandler = new GetPatientByIdQueryHandler(patientReader);
            GetAllPatientsQueryHandler getAllPatientsQueryHandler = new GetAllPatientsQueryHandler(patientReader);

            Guid patientId = createPatientCommandHandler.Handle(
                new CreatePatientCommand
                {
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    DateOfBirth = new DateOnly(1990, 1, 1)
                });

            createPatientCommandHandler.Handle(
                new CreatePatientCommand
                {
                    FirstName = "Joanna",
                    LastName = "Dark",
                    DateOfBirth = new DateOnly(1990, 1, 1)
                });

            var patients = await getAllPatientsQueryHandler.Handle(
                new GetAllPatientsQuery());

            foreach (var currentPatient in patients)
            {
                Console.WriteLine($"ID: {currentPatient.Id}");
                Console.WriteLine($"First name: {currentPatient.FirstName.Value}");
                Console.WriteLine($"Last name: {currentPatient.LastName.Value}");
                Console.WriteLine($"Date of birth: {currentPatient.DateOfBirth}");
                Console.WriteLine("/////////////////////");
            }

            UpdatePatientCommand updatePatientCommand = new UpdatePatientCommand
            {
                Id = patientId,
                LastName = "Paweł",
            };

            updatePatientCommandHandler.Handle(updatePatientCommand);

            var patient = await getPatientByIdQueryHandler.Handle(
                new GetPatientByIdQuery
                {
                    Id = patientId
                });

            patients = await getAllPatientsQueryHandler.Handle(
                new GetAllPatientsQuery());

            foreach (var currentPatient in patients)
            {
                Console.WriteLine($"ID: {currentPatient.Id}");
                Console.WriteLine($"First name: {currentPatient.FirstName.Value}");
                Console.WriteLine($"Last name: {currentPatient.LastName.Value}");
                Console.WriteLine($"Date of birth: {currentPatient.DateOfBirth}");
                Console.WriteLine();
            }

            RemovePatientCommand removePatientCommand = new RemovePatientCommand
            {
                Id = patientId
            };

            removePatientCommandHandler.Handle(removePatientCommand);

            Console.WriteLine($"Patient: {patient.Id} removed");
        }
    }
}
