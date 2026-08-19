using Patient_Management_System.Commands;
using Patient_Management_System.Repositories;
using Patient_Management_System.Interface;
namespace Patient_Management_System.Handlers
{
    public class RemovePatientCommandHandler
    {
        private readonly IPatientWriter _patientWriter;
        public RemovePatientCommandHandler(IPatientWriter patientWriter)
        {
            _patientWriter = patientWriter;
        }
        public void Handle(RemovePatientCommand command)
        {
            _patientWriter.RemovePatient(command.Id);
        }
    }
}
