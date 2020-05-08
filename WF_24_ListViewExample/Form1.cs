using System;
using System.Windows.Forms;

namespace WF_24_ListViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (RadioButton item in groupBox1.Controls)
                {
                    if (item.Checked)
                    {
                        // перетворюємо текст кнопки до значення enum View
                        View view = (View)Enum.Parse(typeof(View), item.Text);
                        listView1.View = view;
                        errorProvider1.SetError((Control)sender, null);
                        break;
                    }
                }
            }
            catch
            {
                if (sender == radioButton5)
                    errorProvider1.SetError((Control)sender, "Change style in context menu");
            }
        }

        private void checkedStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!radioButton5.Checked)
                checkedStyleToolStripMenuItem.Checked = !checkedStyleToolStripMenuItem.Checked;
            listView1.CheckBoxes = checkedStyleToolStripMenuItem.Checked;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            int index;
            while (listView1.SelectedIndices.Count != 0)
            {
                index = listView1.SelectedIndices[0];
                listView1.Items.RemoveAt(index);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    ListViewItem item = new ListViewItem(new[] { textBox1.Text, textBox2.Text, textBox3.Text },
                                                              smallImgList.Images.Count - 1);
                    listView1.Items.Add(item);
                    ClearInputs();
                }
            }
            else
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
            }
        }

        private void ClearInputs()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            item.SubItems[0].Text = textBox1.Text;
            item.SubItems[1].Text = textBox2.Text;
            item.SubItems[2].Text = textBox3.Text;
            ClearInputs();
        }
    }
}
