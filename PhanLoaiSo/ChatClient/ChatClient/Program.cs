using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo Client
            var ip = "127.0.0.1";
            var ipAddress = IPAddress.Parse(ip);
            int port = 1308;
            var ipEndPoint = new IPEndPoint(ipAddress, port);

            //vòng lặp gửi req
            while (true)
            {
                Console.Write("# Nhap vao so: ");
                var req = Console.ReadLine();

                var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipEndPoint);

                NetworkStream stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.WriteLine(req);
                writer.Flush();//đẩy yêu cầu đi

                //Hiện ra màn hình
                var resp = reader.ReadLine();
                Console.WriteLine($"RESULT: {resp}");

                socket.Close();
            }


        }
    }
}
