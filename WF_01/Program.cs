using System.Drawing;
using System.Windows.Forms;
//ctrl + k + e  - clean code
namespace WF_01
{// WinForm
    class Program
    {
        static void Main(string[] args)
        {
            #region MessageBox test
            //DialogResult dialog = MessageBox.Show("Hello!!!", "My first win form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            //switch (dialog)
            //{
            //    case DialogResult.Yes:   // cw  tab tab
            //        Console.WriteLine("You choose Yes");
            //        break;
            //    case DialogResult.No:
            //        Console.WriteLine("You choose No");
            //        break;
            //    case DialogResult.Cancel:
            //        Console.WriteLine("Cancel");
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            Form form = new Form();
            form.Text = "My form";
            //form.Width = SystemInformation.PrimaryMonitorSize.Width / 2;
            //form.Height= 300;

            form.Size = new Size(400, 200);

            //form.StartPosition = FormStartPosition.Manual;
            //form.Top = 0;
            //form.Left = form.Width - form.Width / 2;

            form.Location = new Point(form.Size);
            //form.BackColor = Color.Brown;  // Color - структура для вибору кольору
            form.BackColor = Color.FromArgb(200, 156, 100);

            form.Opacity = 0.75;  // коефіцієнт прозорості (від 0 до 1)

            form.ShowDialog();  // показати форму із затримкою (не закривати відразу)
        }
    }
}
