using Sample2.OCP.Models;
using Sample2.OCP.Services;
using Sample3.LSP.Services;

var report = new Report()
{
    Title = "Monthly Report",
    Message = "This is the content of the monthly report."
};


var exportManager = new ExportManager();

List<BaseExporter> exporters = new List<BaseExporter>
{
    new PdfFileExporter(),
    new SecureEmailExporter(),
    //new PngExporter()
};

foreach (var exporter in exporters)
{
    exportManager.Export(report, exporter);
}

Console.ReadLine();
