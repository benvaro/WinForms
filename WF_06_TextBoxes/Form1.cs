using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_06_TextBoxes
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> accounts = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            tbLogin.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 240;
            accounts["user"] = "user";
            accounts["admin"] = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                this.tbLogin.Focus();
            }
            else
            {
                if (accounts[tbLogin.Text]!=tbPassword.Text)
                {
                    MessageBox.Show("Incorrect password. Try again");
                    this.tbPassword.Text = "";
                    this.tbPassword.Focus();
                    return;
                }
                tbLogin.Enabled = false;
                tbPassword.Enabled = false;
                btnLogin.Enabled = false;
                this.Height = 668;
                listBox1.Items.Add(tbLogin.Text);
                listBox1.Items.Add(tbPassword.Text);
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Text box textChanged!";
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbLogin.Text))
            {
                this.tbLogin.Focus();
            }
            else
            {
                if(!accounts.ContainsKey(tbLogin.Text))
                {
                    MessageBox.Show("Incorrect login");
                    this.tbLogin.Text = "";
                    this.tbLogin.Focus();
                    return;
                }
                
            }
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            TextBox tbMessage = (sender as TextBox);
            int start = tbMessage.SelectionStart;
            int len = tbMessage.SelectionLength;
            lbInfo.Text = $"Stat: Рядків {tbMessage.Lines.Length}\nSymbols {tbMessage.Text.Length}\nStart position {start}" +
                $"\nSelectionLength {len}";
            tbInfo.Text = txtMessage.SelectedText;
        }

        private void txtMessage_MouseCaptureChanged(object sender, EventArgs e)
        {
            tbMessage_TextChanged(sender, null);
        }
    }
}
