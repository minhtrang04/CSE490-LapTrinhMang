using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
namespace ChatServerr
{
    public partial class FormServer : Form
    {
        Socket socket;
        IPEndPoint ipEndPoint;
        IPAddress iPAddress;
        NetworkStream stream;
        static byte[] buffer = new byte[1024];
        TcpClient client;
        TcpListener listener;
        StreamReader reader;
        StreamWriter writer;
        public FormServer()
        {
            InitializeComponent();
            socket = new Socket(SocketType.Stream,ProtocolType.Tcp);

        }

        private void txtIPAServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
            ipEndPoint = new IPEndPoint(IPAddress.Parse(txtIPAClient.Text),int.Parse(txtPortClient.Text));
                reader = new StreamReader(client.GetStream());
                writer = new StreamWriter(client.GetStream());
                writer.Flush();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
            

        }
    }
}
