using SolidPrinciplesTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesTraining.Workers
{
    public class HumanWorker : IWorker, IEatable, ISleepable
    {

        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }
        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine("Worker is sleeping.");
        }
    }
}
