namespace Patient_Management_System.Domain.ValueObjects
{
    public readonly record struct FirstName
    {
        public string Value { get; }
        public FirstName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name can not be empty");
            }
            Value = value;
        }
    }
}
