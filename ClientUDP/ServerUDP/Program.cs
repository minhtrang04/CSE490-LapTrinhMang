using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace ServerUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 1308;

            // Tạo một IPEndPoint để nhận địa chỉ IP và cổng từ client
            EndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, port);
            //IPAddress.Any là lắng nghe tất cả đchi IP,còn cổng chỉ nghe 1308

            // Tạo socket cho UDP
            Socket socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(iPEndPoint);//Gắn địa chỉ IP và cổng với socket.

            //nhận dữ liệu
            var size = 1024;
            var receiByte = new byte[size];//mảng chứa dữ liệu từ client.

            while (true)
            {
                // Nhận dữ liệu từ client và lưu kích thước vào biến length
                var length = socket.ReceiveFrom(receiByte, ref iPEndPoint);

                var req = Encoding.ASCII.GetString(receiByte, 0, length);//Chuyển đổi byte nhận thành chuỗi

                //Tạo phản hồi từ server
                string resp = "Oke em";

                var respByte = Encoding.ASCII.GetBytes(resp);

                // Gửi phản hồi tới client
                socket.SendTo(respByte, iPEndPoint);

                //Array.Clear(respByte, 0, size);
                Console.WriteLine($"Yeu cau: {req}");


            }

        
        }
    }
}
