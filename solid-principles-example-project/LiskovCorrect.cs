namespace solid_principles_example_project;

public interface IAccessData
{
    void ReadFile();
}

public interface IWriteData
{
    void WriteFile();
}

public class AdminDataFileUserCorrect : IAccessData, IWriteData
{  
    public string FilePath { get => FilePath ?? string.Empty; set { FilePath = value; } }
    public void ReadFile()  
    {  
        // Read File logic  
        Console.WriteLine($"File {FilePath} has been read");  
    }  
  
    public void WriteFile()  
    {  
        //Write File Logic  
        Console.WriteLine($"File {FilePath} has been written");  
    }  
}  
  
public class RegularDataFileUserCorrect : IAccessData  
{  
    public string FilePath { get => FilePath ?? string.Empty; set { FilePath = value; } }

    public void ReadFile()
    {
        // Read File logic  
        Console.WriteLine($"File {FilePath} has been read"); 
    }
} 