using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ClientUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo IP và Port:
            string ipString = "127.0.0.1";
            //chuyển string to Ip
            var serverIp = IPAddress.Parse(ipString);

            int port = 1308;

            while (true)
            {
                //1.Nhập yêu cầu và gửi yêu cầu:
                Console.Write("Nhap yeu cau: ");
                var req = Console.ReadLine();

                // Khởi tạo socket UDP
                var socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
                var ipEndPoint = new IPEndPoint(serverIp, port);

                // Chuyển yêu cầu từ chuỗi sang mảng byte để gửi
                var reqByte = Encoding.ASCII.GetBytes(req);

                // Gửi yêu cầu đến server
                socket.SendTo(reqByte, ipEndPoint);
                //đã gửi xong yêu cầu

                //2.nhận dữ liệu
                var size = 1024;
                var receiByte = new byte[size];//mảng chứa dữ liệu từ server.

                EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                //IPAddress.Any, 0:lắn nghe tất cả đchi IP và các cổng bất kỳ 

                //Nhận dữ liệu từ server thông qua UDP socket và trả về độ dài thực của dữ liệu nhận được.
                int length = socket.ReceiveFrom(receiByte, ref endPoint);

                // Chuyển đổi dữ liệu từ mảng byte về chuỗi
                var result = Encoding.ASCII.GetString(receiByte, 0 ,length);

                socket.Close();
                Console.WriteLine($"RESULT: {result}");
            }
            Console.ReadKey();
        }
    }
}
