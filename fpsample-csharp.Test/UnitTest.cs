using System.Threading.Tasks;
using Xunit;
using fpsample_csharp.Lib;

namespace fpsample_csharp.Test
{
    public class UnitTest
    {
        [Fact]
        public async Task Test()
        {
            var state  = new TestState();
            var reader = new TestReader(state);
            var writer = new TestWriter(state);
            var app    = new Application(reader, writer);

            await app.Run();

            Assert.True(state.ReadCalled);
            Assert.True(state.WriteCalled);
        }
    }
}
