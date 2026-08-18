using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    public interface IPatientPriorityStrategy
    {
        int CalculatePriority(Patient patient);
    }
}