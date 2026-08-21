using Patient_Management_System.Application.Commands;
using Patient_Management_System.Application.Interface;

namespace Patient_Management_System.Application.Handlers
{
    public class RemovePatientCommandHandler
    {
        private readonly IPatientWriter _patientWriter;
        public RemovePatientCommandHandler(IPatientWriter patientWriter)
        {
            _patientWriter = patientWriter;
        }
        public Task Handle(RemovePatientCommand command)
        {
            return _patientWriter.RemovePatientAsync(command.Id);
        }
    }
}
