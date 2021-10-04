using System.Threading.Tasks;
using fpsample_csharp.Lib;

namespace fpsample_csharp.Test
{
    internal class TestReader : IDataReader
    {
        private TestState State { get; set; }

        public TestReader(TestState state)
        {
            State = state;
        }

        public Task<Data> Read()
        {
            State.ReadCalled = true;
            return Task.FromResult(new Data("foo", 1));
        }
    }
}
