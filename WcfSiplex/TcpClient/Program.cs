using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TcpClient.WcfSiplexService.WcfSiplexClient("NetTcpBinding_IWcfSiplex");
            Console.WriteLine("NetTcpBinding");
            for (; ; )
            {
                Operation.StartOperations(client);
            }
        }
    }
}
