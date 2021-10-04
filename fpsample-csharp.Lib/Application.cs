using System.Threading.Tasks;

namespace fpsample_csharp.Lib
{
    public class Application
    {
        private IDataReader Reader { get; }
        private IDataWriter Writer { get; }

        public Application(IDataReader reader, IDataWriter writer)
        {
            Reader = reader;
            Writer = writer;
        }

        public async Task Run()
        {
            var data = await Reader.Read();
            await Writer.Write(data);
        }
    }
}
