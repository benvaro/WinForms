using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_25_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.LabelEdit = true; // Дозволяємо редагування вузлів
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            toolStripStatusLabel2.Text = "Selected: " + e.Node.Text;
            toolStripStatusLabel4.Text = e.Node.FullPath;
            this.Text = "Level: " + e.Node.Level;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNode.Text))
                return;
            TreeNode add = new TreeNode(tbNode.Text);
            treeView1.SelectedNode.Nodes.Add(add);
            tbNode.Text = "";
        }

        private void tbNode_Enter(object sender, EventArgs e)
        {
            tbNode.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1/*.SelectedNode*/.Nodes.Clear();
        }

        private void treeView1_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            toolStripStatusLabel2.BackColor = Color.Maroon;
            toolStripStatusLabel2.Text = "Youre going to change text of current node" + e.Node.FullPath;
        }
        bool isCancelled = false;
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            
            if (isCancelled)
            {
                toolStripStatusLabel2.Text = "U changed Text to " + e.Label;
                toolStripStatusLabel2.BackColor = Color.Transparent;
            }
            else
            {
                toolStripStatusLabel2.Text = "U cancelled changes";
                toolStripStatusLabel2.BackColor = Color.LightCoral;
            }
            
        }
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            isCancelled = e.KeyCode == Keys.Escape;
        }

        //private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    isCancelled = e.KeyChar == (char)Keys.Escape;
        //}

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            toolStripStatusLabel4.Text = "U collapsed " + e.Node;
            //   treeView1.CollapseAll();
            foreach (TreeNode item in treeView1.Nodes)
            {
                item.Collapse(); // розгорнути
              //  item.Expand(); // згорнути
            }
            treeView1.Refresh();
        }
       
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            toolStripStatusLabel2.Text = "Before expand " + e.Node;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
      //      treeView1_KeyDown(null, e);
        }
    }
}
