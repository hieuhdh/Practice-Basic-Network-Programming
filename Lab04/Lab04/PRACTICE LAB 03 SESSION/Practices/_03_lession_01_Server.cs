using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _03_lession_01_Server : Form
    {
        public _03_lession_01_Server()
        {
            InitializeComponent();
        }

        private async void deuButton1_Click(object sender, EventArgs e)
        {
            //WaitCallback 
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(Int32.Parse(customTextBox1.Texts));
            while (true)
            {
                IPEndPoint RemotelEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemotelEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                string mess = RemotelEndPoint.Address.ToString() + " sent: " + returnData.ToString();
                InfoMessage(mess);
            }
        }
        public void InfoMessage(string mess)
        {
            listView1.Items.Add(("Host " + mess + "\r\n").ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
