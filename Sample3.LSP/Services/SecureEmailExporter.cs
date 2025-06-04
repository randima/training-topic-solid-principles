using Sample2.OCP.Models;

namespace Sample3.LSP.Services;

public class SecureEmailExporter : BaseExporter
{
    public override void Export(Report report)
    {
        Console.WriteLine($"Securely sending '{report.Title}' by email.");
    }
}