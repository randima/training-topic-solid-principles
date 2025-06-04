using Sample2.OCP.Models;

namespace Sample4.ISP.Interfaces;

public interface ISavable
{
    void Save(Report report, string path);
}