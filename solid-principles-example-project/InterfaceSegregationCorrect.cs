namespace solid_principles_example_project;

public interface IWorkerCorrect
{
    void Work();
}

public interface IHumanWorker : IWorkerCorrect
{
    void Eat();
    void Sleep();
}

public class HumanWorker : IHumanWorker
{
    public void Eat()
    {
        // Nom nom
    }

    public void Sleep()
    {
        // Zzzzzzz
    }

    public void Work()
    {
        // Zug zug
    }
}


public class RobotWorker : IWorkerCorrect
{
    public void Work()
    {
        // Zug zug
    }
}
