using SolidPrinciplesTraining.Interfaces;
using SolidPrinciplesTraining.Workers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesTraining
{
    public class WorkerManager(IWorker worker)
    {
        public void Start()
        {
            worker.Work();
        }
    }
}
