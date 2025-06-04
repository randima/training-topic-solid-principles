using Sample.SRP.Models;

namespace Sample.SRP.Services;

public class ReportPrinter
{
    public void Print(Report report)
    {
        Console.WriteLine($"Printing: {report.Title} - {report.Content}");
    }
}