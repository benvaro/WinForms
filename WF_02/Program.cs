using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "First button";
            form.BackColor = Color.Beige;

            Button button = new Button();
            button.Text = "Click me";
            button.Size = new Size(100, 40);
            button.BackColor = Color.Olive;
            button.ForeColor = Color.Navy;
            button.Font = new Font("Comic Sans MS", 14);
            button.Top = form.Height / 2 - button.Height;
            button.Left = form.Width / 2 - button.Width / 2;
            form.Controls.Add(button); // приєднали кнопку до елементів керування форми

            button.Click += Button_Click;
            button.MouseClick += Button_MouseClick;
            form.MouseClick += Form_MouseClick;
            form.MouseDoubleClick += new MouseEventHandler(Form_MouseDoubleClick);
            form.ShowDialog();
        }

        private static void Form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            (sender as Form).Close();
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            Form temp = sender as Form;
            temp.Text = e.Button + " " + e.Location;

            switch(e.Button)
            {
                case MouseButtons.Left:
                    (sender as Form).BackColor = Color.Yellow;
                    break;
                case MouseButtons.Right:
                    temp.BackColor = Color.LightBlue;
                    break;
            }
        }

        private static void Button_MouseClick(object sender, MouseEventArgs e)
        {
            ((sender as Button).Parent as Form).Text = $"Mouse Click {e.Location}";
        }

        static bool flag = true;
        private static void Button_Click(object sender, EventArgs e)
        {
            if (flag)
                (sender as Button).BackColor = Color.Blue;
            else
                (sender as Button).BackColor = Color.Olive;

            flag = !flag;
        }
    }
}
