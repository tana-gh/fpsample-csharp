using System.Collections.Generic;

namespace fpsample_csharp.Test
{
    internal enum TestEvent
    {
        ReadCalled,
        WriteCalled
    }

    internal class TestState
    {
        public List<TestEvent> Events { get; } = new();
    }
}
