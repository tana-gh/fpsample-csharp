using System.Threading.Tasks;
using fpsample_csharp.Lib;

namespace fpsample_csharp.Test
{
    internal class TestWriter : IDataWriter
    {
        private TestState State { get; set; }

        public TestWriter(TestState state)
        {
            State = state;
        }

        public Task Write(Data data)
        {
            State.Events.Add(TestEvent.WriteCalled);
            return Task.CompletedTask;
        }
    }
}
