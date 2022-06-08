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
    public partial class Main_05 : Form
    {
        public Main_05()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai03 = new lesson05_03();
            bai03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bai04 = new lesson05_04();
            bai04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var bai05 = new lesson05_05();
            bai05.Show();
        }
    }
}
