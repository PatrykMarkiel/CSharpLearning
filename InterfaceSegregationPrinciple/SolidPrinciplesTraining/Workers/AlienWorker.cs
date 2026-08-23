using SolidPrinciplesTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesTraining.Workers
{
    public class AlienWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Alien is working.");
        }
    }
}
