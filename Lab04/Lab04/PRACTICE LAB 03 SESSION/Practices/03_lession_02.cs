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
using System.Diagnostics;

namespace Lab04
{
    public partial class _03_lession_02 : Form
    {
        public _03_lession_02()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bai02_prob = new _03_lession_02_prob();
            bai02_prob.Show();
        }

        private void _03_lession_02_Load(object sender, EventArgs e)
        {

        }

        public void StartUnSafeThread()
        {
            int byteReceived = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenSocket.Bind(ipepServer);
            listenSocket.Listen(-1);
            clientSocket = listenSocket.Accept();
            listView1.Items.Add ("Telnet running on 127.0.0.1:8080");
            //listView1.Items.Add("");
            while (clientSocket.Connected)
            {
                string text = "\n";
                do
                {
                    byteReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listView1.Items.Add(new ListViewItem(text));
                //listView1.Items.Add("\n" + text);
            }
            listenSocket.Close();
        }

        private void deuButton1_Click(object sender, EventArgs e)
        {
            Thread serverthread = new Thread(new ThreadStart(StartUnSafeThread));
            serverthread.Start();
        }

        public static void ExecuteCommand(string command)
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = "-c \" " + command + " \"";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            while (!proc.StandardOutput.EndOfStream)
            {
                Console.WriteLine(proc.StandardOutput.ReadLine());
            }
        }
        private void deuButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "telnet 127.0.0.1 8080";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
