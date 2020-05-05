using System.Windows.Forms;

namespace WF_20_MDI
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }

        private void Child_FormClosing(object sender, FormClosingEventArgs e)
        {
            string title = this.Text;

            var puncts = ((Parent)this.MdiParent).WindowPunct.DropDownItems; // доступ до всіх пунктів меню Window
            for (int i = 0; i < puncts.Count; i++)
            {
                if (puncts[i].Text.Equals(title))
                {
                    puncts.RemoveAt(i);
                    break;
                }
            }
            if (puncts.Count == WF_20_MDI.Parent.COUNT_PUNCTS)
            {
                puncts.RemoveAt(puncts.Count - 1);
            }
        }
    }
}
