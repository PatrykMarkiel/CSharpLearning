using Patient_Management_System.Application.Interface;
using Patient_Management_System.Application.Queries;
using Patient_Management_System.Domain.Entities;

namespace Patient_Management_System.Application.Handlers
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
