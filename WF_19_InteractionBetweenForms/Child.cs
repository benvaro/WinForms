using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_19_InteractionBetweenForms
{
    public partial class Child : Form
    {
        public Parent Parent { get; set; }
        public string NewText
        {
            set
            {
                label4.Text = value;
            }
        }
        public Child()
        {
            InitializeComponent();
        }
        public Child(string text/*, Parent p*/)
        {
            InitializeComponent();
            this.Text = text;
            //   parent = p;

        }
        public void Show(string text)
        {
            label4.Text = text;
            this.splitContainer1.Panel1.BackColor = Color.AliceBlue;
            base.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Parent.BG = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void Child_Activated(object sender, EventArgs e)
        {
            //foreach (var item in Parent.children)
            //{
            //    if (item != (sender as Child))
            //        item.Hide();
            //}

        }
    }
}
