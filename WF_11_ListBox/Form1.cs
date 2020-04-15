using System;
using System.Windows.Forms;

namespace WF_11_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] words = new[] { "one", "two", "three", "four" };
            lbElements.Items.AddRange(words);
            lbElements.Items.Insert(3, "new element");
            lbElements_SelectedIndexChanged(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNew.Text))
                return;

            lbElements.Items.Add(tbNew.Text);
            tbNew.Text = "";
            tbNew.Focus();

        }

        private void lbElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSelected.Text = "";
            if (lbElements.SelectedIndices.Count == 0)
            {
                lbSelected.Text = "Не обрано жодного елемента";
                return;
            }
            foreach (int index in lbElements.SelectedIndices) // readonly
            {
                lbSelected.Text += $"Обрано елемент {lbElements.Items[index]} з індексом: {index}\n";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == rbOne)
                lbElements.SelectionMode = SelectionMode.One;
            else if (rb == rbSimple)
                lbElements.SelectionMode = SelectionMode.MultiSimple;
            else
                lbElements.SelectionMode = SelectionMode.MultiExtended;

            if (lbElements.SelectionMode == SelectionMode.One)
                lbElements_SelectedIndexChanged(null, null);
        }

        private void cbMultiColumn_CheckedChanged(object sender, EventArgs e)
        {
            lbElements.MultiColumn = cbMultiColumn.Checked;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lbElements.SelectedIndices.Count != 0)
                lbElements.Items.RemoveAt(lbElements.SelectedIndices[0]); // 1 2 3
        }
    }
}
