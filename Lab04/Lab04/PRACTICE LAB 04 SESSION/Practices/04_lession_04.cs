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
    public partial class _04_lession_04 : Form
    {
        public _04_lession_04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var app_04 = new _04_lession_04_app();
            app_04.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai04_prob = new _04_lession_04_prob();
            bai04_prob.Show();
        }
    }
}
