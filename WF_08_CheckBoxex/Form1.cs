using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_08_CheckBoxex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            this.Text = $"{check.Checked} --> {check.CheckState} {check.ThreeState}";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../img/1.jpg");
            lblInfo.Text = "";
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox temp = item as CheckBox;
                    temp.ThreeState = false;
                    if (temp.Checked)
                        lblInfo.Text += temp.Text + Environment.NewLine;
                }
            }

        }

        private void checkBoxAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked)
                btn.Enabled = true;
            else
                btn.Enabled = false;
        }
    }
}
