using Patient_Management_System.Interface;
using Patient_Management_System.Models;
using Patient_Management_System.Queries;
using Patient_Management_System.Repositories;

namespace Patient_Management_System.Handlers
{
    internal class GetPatientByIdQueryHandler
    {
        private readonly IPatientReader _patientReader;
        public GetPatientByIdQueryHandler(IPatientReader patientRepository)
        {
            _patientReader = patientRepository;
        }
        public Patient? Handle(GetPatientByIdQuery query)
        {
            return _patientReader.GetPatientById(query.Id);
        }
    }
}
