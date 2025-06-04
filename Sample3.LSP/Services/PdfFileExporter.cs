using Sample2.OCP.Models;

namespace Sample3.LSP.Services;

public class PdfFileExporter : BaseExporter
{
    public override void Export(Report report)
    {
        Console.WriteLine($"Saving '{report.Title}' to file.");
    }
}