using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _03_lession_01_Client : Form
    {
        public _03_lession_01_Client()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] senBytes = Encoding.ASCII.GetBytes(richTextBox1.Text.Trim());
            udpClient.Send(senBytes, senBytes.Length, customTextBox1.Texts.Trim(), Int32.Parse(customTextBox2.Texts));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
