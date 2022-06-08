using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace Lab04
{
    public partial class _04_lession_04_app : Form
    {
        public _04_lession_04_app()
        {
            InitializeComponent();
           
        }

        //private void _04_lession_04_app_KeyDown(object sender, KeyEventArgs e)
        //{
        //    button1.BackColor = Color.Empty;
        //    //button2.BackColor = Color.Empty;
        //    //button3.BackColor = Color.Empty;
        //    //button4.BackColor = Color.Empty;
        //    //button5.BackColor = Color.Empty;
        //    //button6.BackColor = Color.Empty;

        //    switch (e.KeyCode)
        //    {
        //        case (Keys.S): customTextBox1.Texts = "annc"; break;
        //            //case (Keys.S): button2.BackColor = Color.AliceBlue; break;
        //            //case (Keys.A): button3.BackColor = Color.Aquamarine; break;
        //            //case (Keys.D): button4.BackColor = Color.Azure; break;
        //            //case (Keys.X): button5.BackColor = Color.Bisque; break;
        //            //case (Keys.F): button6.BackColor = Color.Blue; break;

        //    }
        //}

        private void _04_lession_04_app_Load(object sender, EventArgs e)
        {
           // InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

      

        private async void button3_Click(object sender, EventArgs e)
        {
            await initizated();
            if (customTextBox1.Texts.Contains("https://"))
                webView21.CoreWebView2.Navigate(customTextBox1.Texts);
            else
                webView21.CoreWebView2.Navigate("https://" + customTextBox1.Texts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(webView21.CoreWebView2.CanGoForward)
                webView21.CoreWebView2.GoForward();
        }

        private async void deuButton1_Click(object sender, EventArgs e)
        {
            await initizated();
            if (customTextBox1.Texts.Contains("https://"))
                webView21.CoreWebView2.Navigate(customTextBox1.Texts);
            else
                webView21.CoreWebView2.Navigate("https://" + customTextBox1.Texts);
        }

        private void deuButton2_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }
    }
}
