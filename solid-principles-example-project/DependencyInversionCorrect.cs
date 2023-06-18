namespace solid_principles_example_project;

public class SenderCorrect
{
    private IEmailService _emailService;

    public SenderCorrect(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void SendEmail(string text)
    {
        // Do some encoding
        _emailService.SendEmail(text);
    }
}

public interface IEmailService { void SendEmail(string text); }

public class EmailServiceCorrect : IEmailService
{
    public void SendEmail(string text)
    {
        // Email go brrr
    }
}