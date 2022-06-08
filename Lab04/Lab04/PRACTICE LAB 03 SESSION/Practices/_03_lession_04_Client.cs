using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _03_lession_04_Client : Form
    {
        public _03_lession_04_Client()
        {
            InitializeComponent();
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage((customTextBox1.Texts + ": " + customTextBox2.Texts).ToString());
        }

        //kết nối

        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            client.Connect(IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {

            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        //đống kết nối
        void Close()
        {
            client.Close();
        }
        //gởi tin
        void Send()
        {
            if ((customTextBox2.Texts != string.Empty) && (customTextBox1.Texts != string.Empty))
            {
                string temp = (customTextBox1.Texts + ": " + customTextBox2.Texts).ToString();
                client.Send(Serialize(temp));
            }
        }
        //nhận tin
        void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Deserialize(data).ToString();

                    AddMessage(message);
                }
                catch
                {
                    Close();
                }
            }

        }
        void AddMessage(string s)
        {
            listView1.Items.Add(new ListViewItem()
            {
                Text = s
            });
            customTextBox2.Texts = "";
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}
