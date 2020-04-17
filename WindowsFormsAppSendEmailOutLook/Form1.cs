using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using outlook = Microsoft.Office.Interop.Outlook;
namespace WindowsFormsAppSendEmailOutLook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ListEmailTo = "";
        public string ListEmailCc = "";
        public string ListEmailSubject = "";
        int nToAll = 0;
        int nCcAll = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            outlook.Application app = new outlook.Application();
            outlook.MailItem mail = (outlook.MailItem)app.CreateItem(outlook.OlItemType.olMailItem);
            //ListEmailTo = listViewTo.TabIndex.ToString();
            //mail.To = "chinh18111993@gmail.com";
            //mail.Subject = "Gui thu tu dong";
            // mail.Body = "Khong co j ";
            mail.To = textBoxTo.Text;
            Thread.Sleep(100);
            mail.CC = textBoxCc.Text;
            Thread.Sleep(100);
            mail.Subject = textBoxSubject.Text;
            Thread.Sleep(100);
            mail.Body = textBoxMessange.Text;
            Thread.Sleep(100);
            if(textBoxFindFile.Text == "")
            {
                MessageBox.Show("Khong dinh kem file nao");
            }
            else
            {
                mail.Attachments.Add(textBoxFindFile.Text);
            }
            Thread.Sleep(100);
            mail.Importance = outlook.OlImportance.olImportanceHigh;
            Thread.Sleep(100);
            ((outlook.MailItem)mail).Send();
            Thread.Sleep(100);
            MessageBox.Show("Đã gởi Email đến " + textBoxTo.Text + " thành công!");

        }
        private void checkBoxSendAll_CheckedChanged(object sender, EventArgs e)
        {
            nToAll = 1 - nToAll;
        }

        private void listBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = "";
            curItem = listBoxTo.SelectedItem.ToString();
            ListEmailTo = curItem;
            textBoxTo.Text += ListEmailTo.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nCcAll = 1 - nCcAll;
        }

        private void listBoxCc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = "";
            curItem = listBoxCc.SelectedItem.ToString();
            ListEmailCc = curItem;
            textBoxCc.Text += ListEmailCc.ToString() + ";";
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                try
                {
                    this.textBoxFindFile.Text = System.IO.Path.GetFullPath(fileName);
                }
                catch (System.Exception)
                {
                }
            }
        }
    }
}
