using Sample2.OCP.Models;
using Sample4.ISP.Interfaces;

namespace Sample4.ISP.Services;

public class FileSaver : ISavable
{
    public void Save(Report report, string path)
    {
        Console.WriteLine($"Saving report '{report.Title}' to {path}");
    }
}