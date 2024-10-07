using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TinhToanServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo server
            int port = 1308;
            Socket listener = new Socket(SocketType.Stream,ProtocolType.Tcp );
            var ipEndPoint = new IPEndPoint(IPAddress.Any, port);
            listener.Bind(ipEndPoint);//Gắn địa chỉ IP và cổng với socket
            listener.Listen(10);//chấp nhận tối đa 10 kết nối đồng thời.
            Console.WriteLine($"Server From {listener.LocalEndPoint}");

            //vòng lặp gửi lại yêu cầu
            while (true)
            {
                Socket worker = listener.Accept();//Chấp nhận kết nối từ client,
                //worker để giao tiếp với client.

                //Tạo một luồng mạng từ socket để đọc/ghi dữ liệu
                NetworkStream stream = new NetworkStream(worker);
                var reader = new StreamReader(stream, Encoding.UTF8);
                var writer = new StreamWriter(stream, Encoding.UTF8);

                string req = reader.ReadLine();//Đọc yêu cầu từ client.
                Console.WriteLine($"Nhan yeu cau: {req}");
                var response = string.Empty;
                try
                {
                    // vị trí xuất hiện phép toán,khởi tạo để lưu lại vị trí
                    int indexOfCaculator = 0;
                    for (int i = 0; i < req.Length; i++)
                    {
                        if (!Char.IsNumber(req[i]))
                        {
                            indexOfCaculator = i;//lưu vị trí phép toán
                            break;
                        }
                    }
                    
                    // phép toán là 1 ký tự tại indexOfCaculator->lấy ktu
                    char phepToan = req[indexOfCaculator];

                    // Chuyển đổi và tính toán hai số
                    // ép kiểu vế trước (A) và vế sau (B), nếu thành công => thực hiện, nếu sai trả về UNKNOW COMMAND
                    if (int.TryParse(req.Substring(0, indexOfCaculator), out int a) && int.TryParse(req.Substring(indexOfCaculator + 1), out int b))
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
                catch (Exception ex)
                {
                    writer.WriteLine("Lỗi: " + ex.Message);
                }
            }

        }
    }
}
