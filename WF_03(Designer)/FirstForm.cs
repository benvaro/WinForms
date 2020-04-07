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

namespace WF_03_Designer_
{
    public partial class FirstForm : Form
    {
        bool isTimerEnabled = false;
        public FirstForm()
        {
            InitializeComponent();
            this.Text = "Hello from designer";
        //    this.btnInfo.Click += BtnInfo_Click;
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            this.lblInfo.Visible = true;
            this.btnInfo.BackColor = Color.Blue;
        }
        
        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            this.lblInfo.Visible = true;
            this.btnInfo.BackColor = Color.Green;
            if (!isTimerEnabled)
                timer.Start();              //timer.Enabled = true;
            else
                timer.Enabled = false;     //timer.Stop();
            isTimerEnabled = !isTimerEnabled;
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Text = "Enter";
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            (sender as Button).Text = "Hover";
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            this.btnInfo.Text = "Leave";
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            lblTime.Text = String.Empty;
        }
        int i = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = ++i + " s";
        }
    }
}
