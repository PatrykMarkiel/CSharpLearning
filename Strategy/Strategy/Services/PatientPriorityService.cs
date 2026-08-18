using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Models;
namespace Strategy.Services
{
    internal class PatientPriorityService
    {
        private readonly IPatientPriorityStrategy _strategy;
        public PatientPriorityService(IPatientPriorityStrategy strategy)
        {
            _strategy = strategy;
        }
        public int GetPriority(Patient patient)
        {
            return _strategy.CalculatePriority(patient);
        }
    }
}
