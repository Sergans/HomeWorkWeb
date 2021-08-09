using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace TaskWeb_1
{
    
    class Program
    {
        static string path = @"C:\Users\GANS\Desktop\HomeWorkWeb\post.txt";
        private static readonly HttpClient client = new HttpClient();
        public static async Task GetAs(int id)
        {    string url = "http://jsonplaceholder.typicode.com/posts/";
             client.DefaultRequestHeaders.Accept.Clear();
             var stringTask = client.GetStringAsync($"{url}/{id}");
           await File.AppendAllTextAsync(path, await stringTask +Environment.NewLine);
           
        }

        static async Task Main(string[] args)
        {
            for (int i = 4; i <= 13; i++)
            {
                await GetAs(i);
            }
           
        }
    }
}
