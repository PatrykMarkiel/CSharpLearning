using SolidPrinciplesTraining;
using SolidPrinciplesTraining.Interfaces;
using SolidPrinciplesTraining.Workers;
public class Program
{
    static void StartWork(IWorker worker)
    {
        worker.Work();
    }

    static void Main()
    {
        IWorker human = new HumanWorker();
        IWorker robot = new RobotWorker();
        IWorker alien = new AlienWorker();

        WorkerManager humanManager = new WorkerManager(new HumanWorker());
        WorkerManager robotManager = new WorkerManager(new RobotWorker());
        WorkerManager alienManager = new WorkerManager(new AlienWorker());

        robotManager.Start();
        alienManager.Start();
        humanManager.Start();

        StartWork(human);
        StartWork(robot);
        StartWork(alien);
    }
}