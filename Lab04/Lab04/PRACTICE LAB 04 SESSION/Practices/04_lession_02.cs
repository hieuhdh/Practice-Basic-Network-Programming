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
using Newtonsoft.Json;

namespace Lab04
{
    public partial class _04_lession_02 : Form
    {
        public _04_lession_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] txt = getHTML(customTextBox1.Texts, customTextBox2.Texts).Split();
            string json = txt[0];
            richTextBox1.Text = getHTML(customTextBox1.Texts, customTextBox2.Texts);
        }

        private string getHTML(string szURL, string content)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(customTextBox1.Texts);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            var result = "";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"ip\":\""+ content +"\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;

            //// Tạo request URL.
            //WebRequest request = WebRequest.Create(szURL);
            //// Đặt thuộc tính là POST
            //request.Method = "POST";
            //// Chuyển đổi content thành một mảng byte.
            //byte[] byteArray = Encoding.UTF8.GetBytes(json);
            //// Đặt thuộc tính ContentType của WebRequest.
            //request.ContentType = "application/x-www-form-urlencoded";
            //// Đặt thuộc tính ContentLength của WebRequest.
            //request.ContentLength = byteArray.Length;
            //// Nhan request yêu cầu.
            //Stream dataStream = request.GetRequestStream();
            //// Write the data to the request stream.
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //// Close the Stream object.
            //dataStream.Close();
            //// Get the response.
            //WebResponse response = request.GetResponse();
            //string responseFromServer;
            //using (dataStream = response.GetResponseStream())
            //{
            //    // Open the stream using a StreamReader for easy access.
            //    StreamReader reader = new StreamReader(dataStream);
            //    // Read the content.
            //    responseFromServer = reader.ReadToEnd();
            //}
            //// Đóng kết nối.
            //response.Close();
            //return responseFromServer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai02_prob = new _04_lession_02_prob();
            bai02_prob.Show();
        }
    }
}
