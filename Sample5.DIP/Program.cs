using Sample2.OCP.Models;
using Sample4.ISP.Interfaces;
using Sample4.ISP.Services;
using Sample5.DIP.Services;

var report = new Report()
{
    Title = "Monthly Report",
    Message = "This is the content of the monthly report."
};

IPrintable printer = new Printer();
ISavable fileSaver = new FileSaver();

var reportProcessor = new ReportProcessor(fileSaver, printer);
reportProcessor.Process(report);


Console.ReadLine();