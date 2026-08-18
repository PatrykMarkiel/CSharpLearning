using System;
using System.Collections.Generic;
using System.Text;
using Patient_Management_System.Models;
namespace Patient_Management_System.Interface
{
    public interface IPatient
    {
        Guid Id { get; }
        string FirstName { get; }
        string LastName { get; }
        DateOnly? DateOfBirth { get; }
    }
}
