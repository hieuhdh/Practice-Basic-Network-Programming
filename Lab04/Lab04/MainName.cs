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
    public partial class MainName : Form
    {
        public MainName()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var main_03 = new Main_03();
            main_03.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var main_04 = new Main_04();
            main_04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var main_05 = new Main_05();
            main_05.Show();
        }
    }
}
