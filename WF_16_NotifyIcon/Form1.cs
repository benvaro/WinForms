using System;
using System.IO;
using System.Windows.Forms;

namespace WF_16_NotifyIcon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog.RootFolder = Environment.SpecialFolder.Fonts;
            folderBrowserDialog.ShowDialog();
            string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
            //File FileInfo
            //Directory  DirectoryInfo
            listBox1.Items.AddRange(files);

            toolStripStatusLabel1.Text = $"Знайдено {files.Length} files";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file = listBox1.SelectedItem.ToString();

            FileInfo fi = new FileInfo(file);
            label1.Text = $"Length: {fi.Length / 1024.0/*Math.Pow(2,30):N2*/} kbytes, Creation: {fi.CreationTime}, " +
                $"Name: {fi.Name}, \nType: {fi.Extension}, Attributes: {fi.Attributes}";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)  // зміна розміру форми (при згортанні-розгортанні)
        {
            if (this.WindowState == FormWindowState.Minimized)
                Form1_DoubleClick(null, null);
        }
    }
}
