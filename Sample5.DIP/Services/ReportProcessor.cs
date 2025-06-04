using Sample2.OCP.Models;
using Sample4.ISP.Interfaces;
using Sample5.DIP.Interfaces;

namespace Sample5.DIP.Services;

public class ReportProcessor : IReportProcessor
{
    private readonly ISavable _saver;
    private readonly IPrintable _printer;

    public ReportProcessor(ISavable saver, IPrintable printer)
    {
        _saver = saver;
        _printer = printer;
    }

    public void Process(Report report)
    {
        _saver.Save(report, "report.txt");
        _printer.Print(report);
    }
}