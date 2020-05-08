using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_23_ListView
{
    public partial class Form1 : Form
    {
        ListView table;
        ListBox box;
        public Form1()
        {
            InitializeComponent();
            table = new ListView();
            table.SetBounds(30, 20, 320, 200);

            this.Controls.Add(table);
            table.Items.Add(new ListViewItem("One"));
            table.Items.Add(new ListViewItem("Two"));
            table.Items.Add(new ListViewItem("Three"));
            table.Items.Add(new ListViewItem("Four"));
            table.Items.Add(new ListViewItem("Five"));
            table.View = View.Tile; //View.Details// у вигляді таблиці  //????

            table.Columns.Add("Name");
            table.Columns[0].Width = 100;
            table.Columns.Add("Column 2");
            table.Columns[1].Width = 100;
            table.Columns.Add("Column 3");
            table.Columns[2].Width = 100;

            table.BackColor = Color.LightGreen;
            table.GridLines = true;
            // додаємо піделементи
            int j = 1;
            foreach (ListViewItem item in table.Items)
            {
                // в кожну колонку додаємо піделемент
                for (int i = 0; i < table.Columns.Count - 1; i++)
                {
                    item.SubItems.Add("subitem " + j++);
                }
            }
            table.DoubleClick += new EventHandler(listView_DoubleClick);
            table.ColumnClick += Table_ColumnClick;
            table.FullRowSelect = true;  // виділяємо весь рядок при клікові
            table.ItemSelectionChanged += Table_ItemSelectionChanged;

            box = new ListBox();
            box.SetBounds(380, 20, 300, 200);
            box.BackColor = Color.LightSalmon;
            this.Controls.Add(box);
            ViewToBox();
        }

        private void ViewToBox()
        {
            // Переглянули колекцію всіх елементів лістВ'ю
            foreach (ListViewItem item in table.Items)
            {
                string temp = "";
                // Перегляд піделементів у кожного елемента
                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                {
                    temp += $"{sub.Text,-15}";
                }
                box.Items.Add(temp);
            }
        }

        private void Table_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.Text = "Selection row change #" + e.ItemIndex;
        }

        // Клікаємо по заголовку колонки
        private void Table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Клік в № колонки
            this.Text = "Click in " + e.Column + " column";
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ListView table = (ListView)sender;
            // видаляємо обраний елемент
            table.Items.Remove(table.SelectedItems[0]);
        }
    }
}