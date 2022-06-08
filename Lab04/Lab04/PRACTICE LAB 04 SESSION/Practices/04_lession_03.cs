
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
    public partial class _04_lession_03 : Form
    {
        public _04_lession_03()
        {
            InitializeComponent();
        }

        private void dowHTML(string szURL, string szURLlocal)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString(szURL);
            FileStream fs = new FileStream(szURLlocal, FileMode.Create);
            StreamWriter fw = new StreamWriter(fs, Encoding.UTF8);
            fw.WriteLine(downloadString.Trim());
            fw.Flush();
            fw.Close();
            fs.Close();

            MessageBox.Show("Success");

            FileStream fsOpen = new FileStream(szURLlocal, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fsOpen);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fsOpen.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dowHTML(customTextBox1.Texts, customTextBox2.Texts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai03_prob = new _04_lession_03_prob();
            bai03_prob.Show();
        }
    }
}
