using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF_09_RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            Color color = Color.FromName(rb.Text);
            if ((rb.Parent as GroupBox).Text.Equals("Background"))
                this.BackColor = color;
            else
                this.ForeColor = color;

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // Background: Green    Foreground: Yellow

            StringBuilder builder = new StringBuilder();
            foreach (var item in this.Controls)
            {
                if (!(item is GroupBox))
                    continue;
                GroupBox box = item as GroupBox;
                builder.Append(box.Text);
                builder.Append(": ");

                foreach (var control in box.Controls)
                {
                    if (!(control is RadioButton))
                        continue;
                    RadioButton btn = control as RadioButton;
                    if (btn.Checked)
                    {
                        builder.Append(btn.Text);
                        break;
                    }
                }
                builder.Append("    ");
            }
            this.Text = builder.ToString();
        }
    }
}
