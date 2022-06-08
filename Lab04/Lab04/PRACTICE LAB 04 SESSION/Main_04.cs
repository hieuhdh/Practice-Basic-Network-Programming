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
    public partial class Main_04 : Form
    {
        public Main_04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bai01 = new _04_lession_01();
            bai01.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bai02 = new _04_lession_02();
            bai02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bai03 = new _04_lession_03();
            bai03.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var bai04 = new _04_lession_04();
            bai04.Show();
        }
    }
}
