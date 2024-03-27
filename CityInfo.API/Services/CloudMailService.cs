namespace CityInfo.API.Services;

public class CloudMailService : IMailService
{
    private string _mailTo = "admin@xyz.com";
    private string _mailFrom = "noreply@xyz.com";

    public void Send(string subject, string message)
    {
        Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with {nameof(CloudMailService)}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
    }
}
