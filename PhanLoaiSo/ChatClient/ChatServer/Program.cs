using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ChatServer
{
    class Program
    {
        // Hàm kiểm tra số nguyên tố
        static bool KtSNT(int number)
        {
            if (number < 2)
            { return false; }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //tạo server
            int port = 1308;
            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
            var ipEndPoint = new IPEndPoint(IPAddress.Any, port);
            listener.Bind(ipEndPoint);//Gắn địa chỉ IP và cổng với socket
            listener.Listen(10);//chấp nhận tối đa 10 kết nối đồng thời.
            Console.WriteLine($"Server From {listener.LocalEndPoint}");

            while (true)
            {
                Socket worker = listener.Accept();

                NetworkStream stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                string req = reader.ReadLine();
                Console.WriteLine($"Nhan yeu cau: {req}");
                var response = string.Empty;
               
                try
                {
                    //ép kiểu
                    if (int.TryParse(req, out int number) == true)
                    {
                        // Kiểm tra chẵn hay lẻ
                        if (number % 2 == 0)
                        {
                            response = "Day la so chan ";
                        }
                        else
                        {
                            response = "Day la so le ";
                        }

                        //Kiểm tra SNT
                        if (KtSNT(number))
                        {
                                response = "+ la so nguyen to";
                            
                        }
                        else if (!KtSNT(number))
                        {
                            response += "+ khong la so nguyen to";
                        }

                    }
                    else
                    {
                        response += "Dinh dang so khong hop le!";
                    }

                }
                catch(Exception ex)
                {
                    writer.WriteLine("Lỗi: " + ex.Message);
                }
                writer.WriteLine(response);
                writer.Flush();
                worker.Close();

            }
        }
    }
}
