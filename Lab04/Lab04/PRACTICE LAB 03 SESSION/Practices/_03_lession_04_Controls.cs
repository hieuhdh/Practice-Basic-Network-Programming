using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class _03_lession_04_Controls : Form
    {
        public _03_lession_04_Controls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bai04_client = new _03_lession_04_Client();
            bai04_client.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bai04_server = new _03_lession_04_Server();
            bai04_server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai04_prob = new _03_lession_04_prob();
            bai04_prob.Show();
        }
    }
}
