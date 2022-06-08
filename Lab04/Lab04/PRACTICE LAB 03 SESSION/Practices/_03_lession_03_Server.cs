﻿using System;
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
    public partial class _03_lession_03_Server : Form
    {
        public _03_lession_03_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _03_lession_03_Server_Load(object sender, EventArgs e)
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
            listView1.Items.Add(new ListViewItem("New client connected"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    byteReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listView1.Items.Add(new ListViewItem(text));
            }
            listenSocket.Close();
        }

        private void deuButton1_Click(object sender, EventArgs e)
        {
            Thread serverthread = new Thread(new ThreadStart(StartUnSafeThread));
            serverthread.Start();
        }
    }
}
