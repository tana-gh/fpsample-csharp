using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using fpsample_csharp.Lib;

namespace fpsample_csharp.App
{
    internal class DataReader : IDataReader
    {
        private static HttpClient HttpClient { get; } = new();

        private string Url { get; }

        public DataReader(string url)
        {
            Url = url;
        }

        public async Task<Data> Read()
        {
            try
            {
                using var res = await HttpClient.GetAsync(Url);
                var stream = await res.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<Data>
                (
                    stream,
                    new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }
                );
            }
            catch
            {
                Console.Error.WriteLine("Fail to read data.");
                throw;
            }
        }
    }
}
