using Sample2.OCP.Models;
using Sample4.ISP.Interfaces;
using Sample4.ISP.Services;

var report = new Report()
{
    Title = "Monthly Report",
    Message = "This is the content of the monthly report."
};

IPrintable printer = new Printer();
printer.Print(report);


ISavable fileSaver = new FileSaver();
fileSaver.Save(report, "monthly_report.txt");


Console.ReadLine();