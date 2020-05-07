using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_22_DragDropImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            this.AllowDrop = true;
            pictureBox1.AllowDrop = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            toolStripStatusLabel1.Text = "Enter form";
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Leave form";
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter picurebox";
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object data = e.Data.GetData(DataFormats.FileDrop);
                string fileName = ((string[])data)[0];
                pictureBox1.Image = Image.FromFile(fileName);
            }
        }
    }
}
