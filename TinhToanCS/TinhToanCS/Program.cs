using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TinhToanClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo client
            var ip = "127.0.0.1";
            var ipAddress = IPAddress.Parse(ip);
            int port = 1308;
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);

            while (true)
            {
                Console.Write("Nhap phep toan: ");
                string req = Console.ReadLine();

                var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipEndPoint);

                NetworkStream stream = new NetworkStream(socket);
                var reader = new StreamReader(stream, Encoding.UTF8);
                var writer = new StreamWriter(stream, Encoding.UTF8);

                writer.WriteLine(req);
                writer.Flush();//đẩy yêu cầu đi

                string response = reader.ReadLine();
                Console.WriteLine($"RESULT: {response}");

            }
            
        }
    }
}
