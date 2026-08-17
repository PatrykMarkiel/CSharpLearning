using Decorator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interfaces
{
    public interface IPatient
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
        DateOnly? DateOfBirth { get; }
    }
}
