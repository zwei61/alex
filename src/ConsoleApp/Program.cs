using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = GetResultAsync();
            Console.WriteLine("main write:"+s.Result.message.Length);
            Console.ReadLine();
        }

        private static async Task<Result> GetResultAsync()
        {
            var s = getstrAsync();
            
            Console.WriteLine("aa");
            var a = await s;
            Console.WriteLine("length:"+a.Length);
            return new Result() { message = a };
        }

        private static async Task<string> getstrAsync()
        {
            Console.WriteLine("getstrAsync");
            Thread.Sleep(1000);
            Console.WriteLine("getstrAsync1");
            HttpClient client = new HttpClient();
            string getStringTask = await client.GetStringAsync("http://msdn.microsoft.com");
            Console.WriteLine("getstrAsync2");
            return getStringTask;
        }
    }

    public class Result
    {
        public string message { get; set; }
    }
}
