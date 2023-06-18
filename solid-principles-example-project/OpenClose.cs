namespace solid_principles_example_project;

public class Course
{
    public int CourseId { get; set; }
    public string? Title { get; set; }
    public string? Type { get; set; }

    public void Subscribe(Student std)
    {
        Logger.Log("Starting Subscribe()");

        //apply business rules based on the course type live, online, offline, if any 
        if (this.Type == "online")
        {
            //subscribe to online course 
        }
        else if (this.Type == "offline")
        {
            //subscribe to offline course 
        }

        // payment processing
        PaymentManager.ProcessPayment();

        //create CourseRepository class to save student and course into StudentCourse table  

        // send confirmation email
        EmailManager.SendEmail();

        Logger.Log("End Subscribe()");
    }
}

internal class EmailManager
{
    internal static void SendEmail()
    {
        // Send an email
    }
}

internal class PaymentManager
{
    internal static void ProcessPayment()
    {
        // Process some payment
    }
}

internal class Logger
{
    internal static void Log(string v)
    {
        // Log some stuff
    }
}

public class Student
{
}