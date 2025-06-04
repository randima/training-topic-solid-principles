using Sample2.OCP.Models;
using Sample2.OCP.Services;

var report = new Report()
{
    Title = "Monthly Report",
    Message = "This is the content of the monthly report."
};


var exportManager = new ExportManager();

var fileExporter = new FileExporter();
exportManager.Export(report, fileExporter);

var emailExporter = new EmailExporter();
exportManager.Export(report, emailExporter);


Console.ReadLine();