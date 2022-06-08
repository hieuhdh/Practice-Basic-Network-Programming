﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _04_lession_01 : Form
    {
        public _04_lession_01()
        {
            InitializeComponent();
        }

        private void _04_lession_01_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = getHTML(customTextBox1.Texts);
        }
        private string getHTML(string szURL)
        {
            // Tạo request URL.
            WebRequest request = WebRequest.Create(szURL);
            // Nhận phản hồi.
            WebResponse response = request.GetResponse();
            // Nhận luồn chứa nội dung trả về từ server.
            Stream dataStream = response.GetResponseStream();
            // Mỡ stream serder để dễ truy cập.
            StreamReader reader = new StreamReader(dataStream);
            // Đọc du liệu.
            string responseFromServer = reader.ReadToEnd();
            // Đóng kết nối.
            response.Close();
            return responseFromServer;
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai01_prob = new _04_lession_01_prob();
            bai01_prob.Show();
        }
    }
}
