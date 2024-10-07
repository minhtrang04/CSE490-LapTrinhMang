using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
namespace ClientTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap IP: ");
            //var ip = Console.ReadLine();
            //Gán địa chỉ IP của máy cục bộ (localhost) vào biến ip
            var ip = "127.0.0.1";

            //Phân tích chuỗi địa chỉ IP và tạo một đối tượng IPAddress tương ứng.
            var ipAddress = IPAddress.Parse(ip);

            //Console.WriteLine("Nhap Port: ");
            //string portstring = Console.ReadLine();
            //int port = int.Parse(portstring);
            int port = 1308;//Đặt số cổng (port) của server là 1308.

            //đại diện cho điểm cuối của kết nối (địa chỉ IP và cổng).
            var iPEndPoint = new IPEndPoint(ipAddress, port);
            while (true)//vòng lặp nhằm gửi nhiều yêu cầu đến server liên tục.
            {
                Console.Write("Nhap yeu cau: ");
                string req = Console.ReadLine();

                // Tạo một đối tượng Socket kiểu luồng do đay là TCP
                var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

                //TCP là giao thức hướng kết nối nên phải connect đến server
                socket.Connect(iPEndPoint);

                //Tạo stream trên socket để truyền dl 2 bên 
                NetworkStream stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);//đọc dl từ NS
                var writer = new StreamWriter(stream);//ghi dl vào NS

                writer.WriteLine(req);//Gửi yêu cầu từ client->server
                writer.Flush();//Đẩy dl đi

                string resp = reader.ReadLine();//đọc phản hồi từ server
                Console.WriteLine($"RESULT: {resp}");
                socket.Close();
            }

            Console.ReadKey();
        }
    }
}
