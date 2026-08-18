using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    public class NormalPriorityStrategy : IPatientPriorityStrategy
    {
        public int CalculatePriority(Patient patient)
        {
            return 1;
        }
    }
}
