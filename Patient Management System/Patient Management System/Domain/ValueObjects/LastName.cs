using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Models;
namespace Patient_Management_System.Domain.ValueObjects
{
    public readonly record struct  LastName
    {
        public string Value { get; }
        public LastName(string value)
        {
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("last name cannot be empty.");
            }
            Value = value;
        }
    }
}
