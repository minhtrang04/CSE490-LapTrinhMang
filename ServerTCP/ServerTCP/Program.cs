using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ServerTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);

            var ipEndPoint = new IPEndPoint(IPAddress.Any, 1308);
            listener.Bind(ipEndPoint);
            listener.Listen(10);

            while (true)
            {
                Socket worker = listener.Accept();

                NetworkStream stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                string req = reader.ReadLine();

                Console.WriteLine($"RESULT: {req} from {worker.RemoteEndPoint}");
                string resp = "Oke ban";

                writer.WriteLine(resp);
                writer.Flush();
                worker.Close();
            }
            Console.ReadKey();
        }
    }
}
