using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_04_Mouse
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            this.lblRect.Text = String.Empty;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse move coords: {e.Location} Pressed button {e.Button}";
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.Size = new Size(3, 3);
                label.BackColor = Color.Olive;
                label.Location = e.Location;
                this.Controls.Add(label);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Label label = new Label();
                label.Size = new Size(5, 5);
                label.BackColor = Color.Navy;
                label.Location = e.Location;
                this.Controls.Add(label);
            }
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            Label start = new Label();
            start.Size = new Size(10, 10);
            start.BackColor = Color.Transparent;
            start.BorderStyle = BorderStyle.FixedSingle;
            start.Location = e.Location;

            this.Controls.Add(start);
        }

        private void MyForm_MouseUp(object sender, MouseEventArgs e)
        {
            Label start = new Label();
            start.Size = new Size(10, 10);
            start.BackColor = Color.Black;
            //     start.BorderStyle = BorderStyle.FixedSingle;
            start.Location = e.Location;

            this.Controls.Add(start);
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.lblRect.Location = new Point(e.X, e.Y);   /*e.Location;*/
            switch (e.Button)
            {
                case MouseButtons.Left:
                    lblRect.BackColor = Color.Green;
                    lblRect.Text = "Left Click";
                    lblRect.Size = new Size(50, 50);
                    break;

                case MouseButtons.Right:
                    lblRect.BackColor = Color.Red;
                    lblRect.Text = "Right Click";
                    lblRect.Size = new Size(50, 50);
                    break;

                default:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.FromName(textBox1.Text);
            }
            catch (ArgumentException exc)
            {
                textBox1.Text = "";
                MessageBox.Show("Invalid color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
