using Sample2.OCP.Models;

namespace Sample3.LSP.Services
{
    public class PngExporter : BaseExporter
    {
        public override void Export(Report report)
        {
            throw new NotImplementedException("Text based report can't be exported as image");
        }
    }
}
