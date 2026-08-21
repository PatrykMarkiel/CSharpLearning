using Patient_Management_System.Application.Interface;
using Patient_Management_System.Application.Queries;
using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Application.Handlers
{
    public class GetAllPatientsQueryHandler
    {
        private readonly IPatientReader _patientReader;
        public GetAllPatientsQueryHandler(IPatientReader patientReader)
        {
            _patientReader = patientReader;
        }
        public IEnumerable<Patient> Handle(GetAllPatientsQuery query)
        {
            return _patientReader.GetAllPatients();
        }
    }
}
