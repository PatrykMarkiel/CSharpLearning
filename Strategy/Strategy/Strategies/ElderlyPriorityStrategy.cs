using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Models;
namespace Strategy.Strategies
{
    public class ElderlyPriorityStrategy : IPatientPriorityStrategy
    {
        public int CalculatePriority(Patient patient)
        {
            return 50;
        }
    }
}
