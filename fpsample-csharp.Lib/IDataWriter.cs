using System.Threading.Tasks;

namespace fpsample_csharp.Lib
{
    public interface IDataWriter
    {
        Task Write(Data data);
    }
}
