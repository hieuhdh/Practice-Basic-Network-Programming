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
    public partial class _03_lession_01_Controls : Form
    {
        public _03_lession_01_Controls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client_form = new _03_lession_01_Client();
            client_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai01_prob = new _03_lession_01_prob();
            bai01_prob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var serrver_form = new _03_lession_01_Server();
            serrver_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
