using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_20_MDI
{
    public partial class Parent : Form
    {
        public static readonly int COUNT_PUNCTS = 8;
        public Parent()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }
        int id = 0; // number of child window
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.Text += $" {++id}";
            child.MdiParent = this;
            child.Show();

            if (id == 1)
                windowToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            ToolStripMenuItem newItem = new ToolStripMenuItem(); // створили пункт меню
            newItem.Text = child.Text;
            #region click via anonimous delegate
            //newItem.Click += new EventHandler(
            //    delegate(object s, EventArgs args)
            //    {
            //        child.Focus();
            //    }
            //    ); 
            #endregion
            #region click via labmda
            newItem.Click += (o, s) =>
            {
                child.Focus();
                if (child.WindowState == FormWindowState.Minimized)
                    child.WindowState = FormWindowState.Normal;
            };
            #endregion
            windowToolStripMenuItem.DropDownItems.Add(newItem); // додали щойно створений пункт
            newItem.Checked = true;
            toolStripStatusLabel1.Text = child.Text;
            
        }
        public ToolStripMenuItem WindowPunct
        {
            get
            {
                return this.windowToolStripMenuItem;
            }
        }
        private void Parent_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
                return;
            Child child = (Child)this.ActiveMdiChild;
            if(child == null)
            {
                toolStripStatusLabel1.Text = "";
                id = 0;
                return;
            }
            foreach (ToolStripItem item in windowToolStripMenuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                    if (item.Text.Contains(child.Text))
                    {
                        (item as ToolStripMenuItem).Checked = true;
                    }
                    else
                        (item as ToolStripMenuItem).Checked = false;
            }

            toolStripStatusLabel1.Text = child.Text;
        }

        private void tileCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }

        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Normal;
            }
        }
    }
}
