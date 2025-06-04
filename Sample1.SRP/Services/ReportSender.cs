using Sample.SRP.Models;

namespace Sample.SRP.Services;

public class ReportSender
{
    public void SendByEmail(Report report, string email)
    {
        Console.WriteLine($"Sending report '{report.Title}' to {email}");
    }
}