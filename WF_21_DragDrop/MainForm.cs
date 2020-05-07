using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_21_DragDrop
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            // дозволяємо списку бути адресатом переміщення (буксирування)
            lbDestination.AllowDrop = true;
        }

        private void tbSource_MouseDown(object sender, MouseEventArgs e)
        {
            // при зажиманні кнопки миші виконуємо перетягування вмістимого "джерела" (тексту)
            if (!String.IsNullOrWhiteSpace(tbSource.Text))
                tbSource.DoDragDrop(tbSource.Text, DragDropEffects.Copy);
        }

        private void lbDestination_DragEnter(object sender, DragEventArgs e)
        {
            // при перетягування на лістбокс встановлюємо ефект курсора на "копія" - дозволяємо операцію копіювання
            if (e.Data.GetDataPresent(/*DataFormats.StringFormat*//*tbSource.Text.GetType()*/typeof(String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lbDestination_DragDrop(object sender, DragEventArgs e)
        {
            // при відпусканні кнопки миші копіюємо дані в елемент списку
            lbDestination.Items.Add(e.Data.GetData(typeof(String)));
            this.Text = "Drag & Drop finished";
        }

        private void lbDestination_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbDestination.SelectedItem != null)
                lbDestination.DoDragDrop(lbDestination.SelectedItem, DragDropEffects.None);

            

        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Text = "Drag Over Form";
        }
    }
}
