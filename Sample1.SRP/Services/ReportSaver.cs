using Sample.SRP.Models;

namespace Sample.SRP.Services;

public class ReportSaver
{
    public void SaveToFile(Report report, string filename)
    {
        Console.WriteLine($"Saving {report.Title} to {filename}");
    }
}