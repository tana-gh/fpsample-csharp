using System.Threading.Tasks;
using CommandLine;
using fpsample_csharp.Lib;

namespace fpsample_csharp.App
{
    internal class Options
    {
        [Option("url", Required = true, HelpText = "Set url for reading data.")]
        public string Url { get; set; }
    }

    internal class Program
    {
        private static Task Main(string[] args)
        {
            return Parser.Default.ParseArguments<Options>(args).WithParsedAsync<Options>(o =>
            {
                var reader = new DataReader(o.Url);
                var writer = new DataWriter();
                var app    = new Application(reader, writer);
                return app.Run();
            });
        }
    }
}
