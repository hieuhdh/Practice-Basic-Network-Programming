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
    public partial class _03_lession_03 : Form
    {
        public _03_lession_03()
        {
            InitializeComponent();
        }

        private void _03_lession_01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bai03_prob = new _03_lession_03_prob();
            bai03_prob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bai03_server = new _03_lession_03_Server();
            bai03_server.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai03_client = new _03_lession_03_Client();
            bai03_client.Show();
        }
    }
}
