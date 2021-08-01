using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TaskWeb_1
{
    
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task GetAs(int id)
        {    string url = "http://jsonplaceholder.typicode.com/posts/";
             client.DefaultRequestHeaders.Accept.Clear();
             var stringTask = client.GetStringAsync($"{url}/{id}");
             var msg = await stringTask;
             Console.Write(msg);
        }

        static async Task Main(string[] args)
        {
          await GetAs(1);
          await GetAs(2);
        }
    }
}
