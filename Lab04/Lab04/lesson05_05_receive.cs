﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System.Security.Authentication;
using MailKit.Security;

namespace Lab04
{
    public partial class ReceiveMail : Form
    {
        string name;
        string pass;
        public ReceiveMail(string names, string pass)
        {
            InitializeComponent();
            this.name = names;
            this.pass = pass;
            using (var client = new ImapClient())
            {
                client.CheckCertificateRevocation = false;
                client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                client.Authenticate(names, pass);
                // The Inbox folder is always available on all IMAP servers...
                var inbox = client.Inbox;

                inbox.Open(FolderAccess.ReadOnly);
                lbTotal.Text = inbox.Count.ToString();
                lbRecent.Text = inbox.Recent.ToString();

                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 100);
                listView1.Columns.Add("Thời gian", 100);
                listView1.View = View.Details;

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    listView1.Items.Add(name);
                }

                client.Disconnect(true);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
            string[] arrListStr;
            try
            {
                arrListStr = listView1.SelectedItems[0].SubItems[1].Text.Split('"');

                lesson05_05_read readMail = new lesson05_05_read(name, pass, arrListStr[2].Trim().Substring(1, arrListStr[2].Trim().Length - 2), listView1.SelectedItems[0].SubItems[0].Text);
                readMail.Show();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lesson05_05_send sendMail = new lesson05_05_send(name, pass);
            sendMail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lesson05_05 form1 = new lesson05_05();
            form1.Show();
            this.Close();
        }
    }
}

