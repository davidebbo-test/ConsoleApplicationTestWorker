using System;
using System.Collections.Generic;
using System.Configuration;
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
            int sleepTime = Int32.Parse(ConfigurationManager.AppSettings["SleepTime"]);
            for (int i = 0; ; i++)
            {
                var client = new HttpClient();
                var response = client.GetAsync(String.Format("http://davidebbo.com/qqq/{0}", i)).Result;
                Console.WriteLine(response.StatusCode);
                Thread.Sleep(sleepTime);
            }
        }
    }
}
