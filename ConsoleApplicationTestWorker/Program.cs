using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationTestWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                var client = new HttpClient();
                var response = client.GetAsync(String.Format("http://davidebbo.com/qqq/{0}", i)).Result;
                Console.WriteLine(response.StatusCode);
                Thread.Sleep(5000);
            }
        }
    }
}
