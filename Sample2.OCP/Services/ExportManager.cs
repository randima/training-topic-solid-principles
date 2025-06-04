using Sample2.OCP.Interfaces;
using Sample2.OCP.Models;

namespace Sample2.OCP.Services;

public class ExportManager
{
    public void Export(Report report, IReportExporter exporter)
    {
        exporter.Export(report);
    }
}