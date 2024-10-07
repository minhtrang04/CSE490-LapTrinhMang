using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TCP Server: ";
            var listenner = new Socket(SocketType.Stream, ProtocolType.Tcp);
            listenner.Bind(new IPEndPoint(IPAddress.Any, 1308));
            listenner.Listen(10);
            Console.WriteLine($"Server started at {listenner.LocalEndPoint}");

            while (true)
            {
                var worker = listenner.Accept();

                var stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);

                var request = reader.ReadLine();
                var response = string.Empty;

                // vị trí xuất hiện phép toán
                int indexOfCaculator = 0;
                for (int i = 0; i < request.Length; i++)
                {
                    if (!Char.IsNumber(request[i]))
                    {
                        indexOfCaculator = i;
                        break;
                    }
                }

                // phép toán là 1 ký tự tại indexOfCaculator
                char phepToan = request[indexOfCaculator];
                
                // ép kiểu vế trước (A) và vế sau (B), nếu thành công => thực hiện, nếu sai trả về UNKNOW COMMAND
                if (int.TryParse(request.Substring(0, indexOfCaculator), out int a) && int.TryParse(request.Substring(indexOfCaculator + 1), out int b))
                {
                    switch (phepToan)
                    {
                        case '+':
                            response = (a + b).ToString();
                            break;

                        case '-':
                            response = (a - b).ToString();
                            break;

                        case '*':
                            response = (a * b).ToString();
                            break;

                        case '/':
                            response = ((decimal)a / b).ToString();
                            break;
                        default:
                            response = "UNKNOWN COMMAND";
                            break;
                    }
                }
                else
                {
                    response = "UNKNOW COMMAND";
                }

                writer.WriteLine(response);
                writer.Flush();
                worker.Close();
            }
        }
    }
}
