using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stub.Client.nsi;

namespace Stub.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client starting....");
            using (NsiClient client = new NsiClient())
            {
                var header = new RequestHeader();
                var request = new exportNsiListRequest();
                var result = client.exportNsiList(ref header, request);
                Console.WriteLine("Request id is {0}", request.Id);
            }
            Console.WriteLine("Client will be terminated.");
            Console.ReadKey();
        }
    }
}
