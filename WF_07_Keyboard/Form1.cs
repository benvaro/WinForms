using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_07_Keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
                e.Handled = true;
            lbInfo.Text = "KeyDown: " + e.KeyCode + " Mofifiers: " + e.Modifiers; 
        }

        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            lbInfo.Text += "\nKeyPress: " + e.KeyChar;
        }

        private void tbText_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
                e.Handled = true;
            lbInfo.Text += "\nKeyUp: " + (char)e.KeyValue + " Modifiers: " + e.Modifiers;
        }
    }
}
