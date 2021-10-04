using System.Threading.Tasks;

namespace fpsample_csharp.Lib
{
    public interface IDataReader
    {
        Task<Data> Read();
    }
}
