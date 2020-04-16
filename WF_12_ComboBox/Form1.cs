using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WF_12_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //    string[] colors = new[] { "Red", "Green", "Blue"};
            //     cbColor.Items.AddRange(colors);

            cbColor.Items.AddRange(typeof(Color).GetProperties()  // Рефлексія
                        .Select(x => x.Name).ToArray()); // LINQ-метод

            for (int i = 0; i < 9; i++)
            {
                cbColor.Items.RemoveAt(cbColor.Items.Count - 1);
            }
            cbColor.Items.RemoveAt(0);
            cbColor.SelectedIndex = new Random().Next(0, cbColor.Items.Count);

            string[] types = new[] { "Акрилова", "Латексна", "Акварель", "Гуаш", "Олія" };
            chlbType.Items.AddRange(types);

            string[] makers = new[] { "Sniezka", "Зебра", "Royal", "Веселка", "Колорит" };
            lbManufacturer.Items.AddRange(makers);
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            lblColor.BackColor = Color.FromName(box.SelectedItem.ToString());
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown1.Value);
            if (lbManufacturer.SelectedItem == null || chlbType.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Nothing choosed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //      return;
            }
            try
            {
                List<string> types = new List<string>();
                foreach (var item in chlbType.CheckedItems)
                {
                    types.Add(item.ToString());
                }

                string maker = lbManufacturer.SelectedItem.ToString();
                string color = cbColor.Text;

                string result = $"Manufacturer: {maker}, Color: {color}, Count (liters): {count}";
                string type = Environment.NewLine + "Types: ";
                foreach (var item in types)
                {
                    type += item + ", ";
                }
                result += type;
                result = result.Substring(0, result.Length - 2);
                lbResult.Items.Add(result);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lbResult.SelectedIndices.Count > 0)
                lbResult.Items.RemoveAt(lbResult.SelectedIndices[0]);
        }
    }
}
