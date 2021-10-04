using System;
using System.Threading.Tasks;
using fpsample_csharp.Lib;

namespace fpsample_csharp.App
{
    internal class DataWriter : IDataWriter
    {
        public Task Write(Data data)
        {
            Console.WriteLine($"name={data.Name}");
            Console.WriteLine($"age={data.Age}");
            return Task.CompletedTask;
        }
    }
}
