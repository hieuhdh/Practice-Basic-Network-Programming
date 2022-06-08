
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _03_lession_03_Client : Form
    {
        public _03_lession_03_Client()
        {
            InitializeComponent();
        }

        private void deuButton1_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipEndPoint);

            NetworkStream ns = tcpClient.GetStream();

            Byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello server\n");
            ns.Write(data, 0, data.Length);

            Byte[] data2 = System.Text.Encoding.ASCII.GetBytes("quit\n");
            ns.Write(data2, 0, data2.Length);
            ns.Close();
            tcpClient.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
