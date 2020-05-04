using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Способи передачі даних з Батьківської форми на дочірню:
// 1) Відкрита властивість у дочірній формі
// 2) конструктор з параметром  (одноразовий вплив)
// 3) перевантажити метод Show() для класу доч. форми

// З дочірньої на батьківську
// 1) на дочірній екземпляр (поле) або відкрита властивість батьківської
// 2) на батьківській відкрита властивість

namespace WF_19_InteractionBetweenForms
{
    public partial class Parent : Form
    {
     public List<Child> children = new List<Child>();
        public Parent()
        {
            InitializeComponent();
        }
        public Color BG
        {
            set
            {
                this.BackColor = value;
                foreach (Control item in this.Controls)
                {
                    item.BackColor = value;
                }
            }
        }
        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            Child child = MakeChildForm();
            DialogResult dr = child.ShowDialog();
        //    MessageBox.Show($"MessageBox after child.ShowDialog() with result {0}", dr.ToString());
        }

        private Child MakeChildForm()
        {
            Child form = null;
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                form = new Child();
            else
                form = new Child(textBox1.Text);
            form.Parent = this;
            return form;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Child child = MakeChildForm();
            child.Show();
       //     MessageBox.Show($"MessageBox after child.Show() with result");
            children.Add(child);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < children.Count; i++)
            {
                children[i].NewText = textBox1.Text;
            }
        }

        private void btnShow_ClickOverload(object sender, EventArgs e)
        {
            Child child = MakeChildForm();
            child.Show(textBox1.Text);
            children.Add(child);
        }

        private void Parent_Activated(object sender, EventArgs e)
        {
            //if(children.Count != 0)
            //    foreach (var item in children)
            //    {
            //        item.Show();
            //    }
        }
    }
