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
            //Khởi tạo socket
            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);

            int port = 1308;
            var ipEndPoint = new IPEndPoint(IPAddress.Any, port);
            //IPAddress.Any: Lang nghe tat ca cac dia chi IP khả dụng.
            listener.Bind(ipEndPoint);////Gắn địa chỉ IP và cổng với socket.
            listener.Listen(10);//lắng nghe với tối đa 10 kết nối

            while (true)//vòng lặp để nhận/gửi yêu cầu
            {
                //chấp nhận kết nối từ Client
                Socket worker = listener.Accept();

                //Tạo stream trên socket để truyền dl 2 bên 
                NetworkStream stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                //Hiển thi yêu cầu client ra màn hình
                string req = reader.ReadLine();
                Console.WriteLine($"RESULT: {req} from {worker.RemoteEndPoint}");

                ////Tạo phản hồi từ server
                Console.Write("Nhap yeu cau: ");
                string resp = Console.ReadLine();

                writer.WriteLine(resp);//Gui cau tra loi toi client
                writer.Flush();//Đẩy dl đi
                worker.Close();
            }
                Console.ReadKey();
        }
    }
}
