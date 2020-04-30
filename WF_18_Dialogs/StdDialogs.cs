using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_18_Dialogs
{
    public partial class StdDialogs : Form
    {
        public StdDialogs()
        {
            InitializeComponent();
            for (int i = 8; i < 72; i+=2)
            {
                toolStripComboBox1.Items.Add(i);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files(*.txt)|*.txt|All files|*.*"; // фільтр для файлів: Назва фільтру|маска фільтру
            of.FileName = "Type name here";
            of.InitialDirectory = @"C:\Users\Luda\Desktop";
            var dialogResult = of.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //  var result = File.ReadAllText(of.FileName);
                //  richTextBox1.Text = result;
                if (Path.GetExtension(of.FileName) == ".rtf")
                    richTextBox1.LoadFile(of.FileName);
                else
                    richTextBox1.LoadFile(of.FileName, RichTextBoxStreamType.UnicodePlainText);
            }
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                if (richTextBox1.SelectionLength != 0)
                    richTextBox1.SelectionColor = colorDialog1.Color;
                else
                    richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // enum -- 0 1 2
            // 00000000  - bold
            // 00000001  - italic
            // 00000010  - underline
            // 00000000 | 00000010 == 11111100  ?
            // |    &    - побітове додавання  та виключення


            FontDialog fontDialog1 = new FontDialog();   // працює, бо обмежено областю локальної видимості
            fontDialog1.Font = new Font("Comic Sans MS", 18, FontStyle.Bold | FontStyle.Underline);
            fontDialog1.ShowColor = true;
            fontDialog1.Color = Color.DarkSlateGray;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength != 0)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
        }

        private void folderBrowserDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text files(*.txt)|*.txt|All files|*.*";
            sd.InitialDirectory = @"C:\Users\Luda\Desktop";
            sd.OverwritePrompt = true;
            sd.ShowDialog();
            //  File.WriteAllText(sd.FileName, richTextBox1.Text); // write as plain text
            richTextBox1.SaveFile(sd.FileName, RichTextBoxStreamType.UnicodePlainText);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void alignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(toolStripComboBox1.SelectedItem));
        }
    }
}
