using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_17_ErrorProvider
{
    public partial class Form1 : Form
    {
        bool validName = false;
        bool validPrice = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validName && validPrice)
            {
                listBox1.Items.Add($"{textBox1.Text} --- {textBox2.Text} $");
            }
            else
                errorProvider1.SetError((sender as Button), "Не всі поля заповнені");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are u sure?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                e.Cancel = true;   // Забороняємо спливання події form_closed (форма не закриється)
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Text = "Wait for closing....";
            Thread.Sleep(1000);
        }
    }
}
