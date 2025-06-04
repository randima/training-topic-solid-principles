using Sample2.OCP.Models;
using Sample4.ISP.Interfaces;

namespace Sample4.ISP.Services;

public class Printer : IPrintable
{
    public void Print(Report report)
    {
        Console.WriteLine($"Printing: {report.Title}");
    }
}