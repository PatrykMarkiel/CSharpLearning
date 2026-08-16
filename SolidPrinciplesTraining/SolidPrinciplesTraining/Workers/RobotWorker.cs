using SolidPrinciplesTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesTraining.Workers
{
    public class RobotWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
