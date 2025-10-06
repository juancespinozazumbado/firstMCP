namespace Server.Tools;

public interface IEmailService
{
    
    Task<int> SendEmailAsync(string owner, string repo);
}
