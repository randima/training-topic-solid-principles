using Sample2.OCP.Interfaces;
using Sample2.OCP.Models;

namespace Sample3.LSP.Services
{
    public abstract class BaseExporter : IReportExporter
    {
        public abstract void Export(Report report);
    }
}
