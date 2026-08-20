using Patient_Management_System.Application.Commands;
using Patient_Management_System.Application.Handlers;
using Patient_Management_System.Application.Interface;
using Patient_Management_System.Application.Queries;
using Patient_Management_System.Infrastructure.Repositories;

namespace Patient_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientRepository patientRepository = new PatientRepository();
            IPatientReader patientReader = patientRepository;
            IPatientWriter patientWriter = patientRepository;

            CreatePatientCommandHandler createPatientCommandHandler = new CreatePatientCommandHandler(patientWriter);
            UpdatePatientCommandHandler updatePatientCommandHandler = new UpdatePatientCommandHandler(patientReader, patientWriter);
            RemovePatientCommandHandler removePatientCommandHandler = new RemovePatientCommandHandler(patientWriter);
            GetPatientByIdQueryHandler getPatientByIdQueryHandler = new GetPatientByIdQueryHandler(patientReader);

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
