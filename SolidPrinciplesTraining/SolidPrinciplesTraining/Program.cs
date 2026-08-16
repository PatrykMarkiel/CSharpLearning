public interface IWorker
{
    void Work();
}
public interface IEatable
{
    void Eat();
}
public interface ISleepable
{
    void Sleep();
}
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
public class RobotWorker:IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}