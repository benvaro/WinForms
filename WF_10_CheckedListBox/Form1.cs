using System;
using System.Windows.Forms;

namespace WF_10_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clbExample.Items.Add("six", false);  // 
            clbExample.Items.Add("seven", true);
            clbExample_SelectedIndexChanged(null, null);
        }

        private void clbExample_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSelected.Text = "";
            //  CheckedListBox temp = (sender as CheckedListBox);
            if (clbExample.CheckedIndices.Count == 0)
            {
                lbSelected.Text = "Не обрано жодного елемента";
                return;
            }
            foreach (int index in clbExample.CheckedIndices) // readonly
            {
                lbSelected.Text += $"Обрано елемент {clbExample.Items[index]} з індексом: {index}\n";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (clbExample.CheckedIndices.Count != 0)
                clbExample.Items.RemoveAt(clbExample.CheckedIndices[0]); // 1 2 3
            clbExample_SelectedIndexChanged(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNew.Text))
                return;

            clbExample.Items.Add(tbNew.Text);
            tbNew.Text = "";
            tbNew.Focus();
        }

        private void tbNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnAdd_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbSearch.Visible = true;
            tbSearch.Focus();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbSearch.Focused)
                this.AcceptButton = null;
            if (e.KeyCode == Keys.Return)
            {
                if (clbExample.Items.Contains(tbSearch.Text))
                    clbExample.Items.Remove(tbSearch.Text);

                tbSearch.Text = "";
                clbExample_SelectedIndexChanged(null, null);
            }
        }
    }
}
