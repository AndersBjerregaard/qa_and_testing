namespace solid_principles_example_project;

public class Sender
{
    private EmailService _emailService = new EmailService();

    public void SendEmail(string text)
    {
        // Do some encoding
        _emailService.SendEmail(text);
    }
}

public class EmailService
{
    internal void SendEmail(string text)
    {
        // Email go brrrr
    }
}