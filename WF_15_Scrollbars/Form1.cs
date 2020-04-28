using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WF_15_Scrollbars
{
    public partial class MainForm : Form
    {
        List<string> names = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            hScrollBar1.Maximum = imageList1.Images.Count - 1;
            hScrollBar1.LargeChange = hScrollBar1.SmallChange = 1;

            toolStripProgressBar1.Maximum = imageList1.Images.Count;

            names.AddRange(new[]{ "Picture 1", "Picture 2",
                               "Picture 3"});

            pictureBox1.Image = imageList1.Images[0];
            toolStripProgressBar1.Value = 1;

            linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = "https://google.com" });
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int j = hScrollBar1.Value; // 0
            pictureBox1.Image = imageList1.Images[j];
            toolStripStatusLabel1.Text = names[j];
            toolStripProgressBar1.Value = j + 1;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems[0].Text = names[hScrollBar1.Value];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());   // linkLabel1.Links[0].LinkData
        }
    }
}
