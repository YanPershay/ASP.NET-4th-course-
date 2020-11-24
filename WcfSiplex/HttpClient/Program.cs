using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations;

namespace HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WcfSiplexService.WcfSiplexClient("BasicHttpBinding_IWcfSiplex");
            Console.WriteLine("BasicHttpBinding");
            for (; ; )
            {
                Operation.StartOperations(client);
            }
        }
    }
}
