using System;
using WeebWrap;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
            Console.ReadLine();
        }

        async void Start()
        {
            WeebWrapClient _client = new WeebWrapClient();
            var post = await _client.SearchOnePostAsync(Provider.Yandere, "miku");
            Console.WriteLine(post.JpegUrl);
            await Task.Delay(-1);
        }
    }
}