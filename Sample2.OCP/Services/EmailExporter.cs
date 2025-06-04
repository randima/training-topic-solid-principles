using Sample2.OCP.Interfaces;
using Sample2.OCP.Models;

namespace Sample2.OCP.Services;

public class EmailExporter : IReportExporter
{
    public void Export(Report report)
    {
        Console.WriteLine($"Sending {report.Title} by email.");
    }
}