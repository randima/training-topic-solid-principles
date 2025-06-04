using Sample.SRP.Models;
using Sample.SRP.Services;


var report = new Report()
{
    Title = "Monthly Report",
    Content = "This is the content of the monthly report."
};

var printer = new ReportPrinter();
printer.Print(report);

var saver = new ReportSaver();
saver.SaveToFile(report, "monthly_report.txt");

var sender = new ReportSender();
sender.SendByEmail(report, "user@example.com");

Console.ReadLine();
