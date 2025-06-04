using Sample2.OCP.Interfaces;
using Sample2.OCP.Models;

namespace Sample2.OCP.Services
{
    public class FileExporter : IReportExporter
    {
        public void Export(Report report)
        {
            Console.WriteLine($"Exporting {report.Title} to file.");
        }
    }
}
