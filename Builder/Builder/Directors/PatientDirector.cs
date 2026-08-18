using Builder.Builders;
using Builder.Models;

namespace Builder.Directors
{
    public class PatientDirector
    {
        private readonly IPatientBuilder _builder;

        public PatientDirector(IPatientBuilder builder)
        {
            _builder = builder;
        }

        public Patient BuildBasicPatient()
        {
            _builder.SetId(Guid.NewGuid());
            _builder.SetFirstName("Jan");
            _builder.SetLastName("Kowalski");

            return _builder.Build();
        }
        public Patient BuildCompletePatient()
        {
            _builder.SetId(Guid.NewGuid());
            _builder.SetFirstName("Jan");
            _builder.SetLastName("Kowalski");
            _builder.SetDateOfBirth(new DateOnly(1990, 1, 1));
            _builder.SetPhoneNumber("123-456-789");
            _builder.SetEmail("jan.kowalski@example.com");
            _builder.SetAddress("Adamczycha 1670");
            return _builder.Build();
        }
        public Patient BuildEmergencyPatient()
        {
            _builder.SetId(Guid.NewGuid());
            _builder.SetFirstName("Jan");
            _builder.SetLastName("Kowalski");
            _builder.SetPhoneNumber("123-456-789");
            return _builder.Build();
        }
        public Patient Build()
{
    Patient result = _patient;
    _patient = new Patient();

    return result;
}
    }
}