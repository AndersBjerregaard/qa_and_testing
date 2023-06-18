namespace solid_principles_example_project;

public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Human : IWorker
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


public class Robot : IWorker
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        // Zug zug
    }
}
