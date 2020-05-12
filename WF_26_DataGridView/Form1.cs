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

namespace WF_26_DataGridView
{
    public partial class Form1 : Form
    {
        BookStore store = new BookStore();
        Garage garage = new Garage();
        DataSet dataSet = null;  // набір даних, складається з таблиць
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = toolStripStatusLabel2.Text = "";
            InitData();
        }

        void InitData()
        {
            // 1 спосіб заповнення датаГріда
            //----------------------------------
            foreach (Book item in store)
            {
                dataGridView1.Rows.Add(item.Title, item.Author, item.Available);
            }
            //----------------------------------
            // 2-ий спосіб, заповнюємо 
            foreach (Car item in garage)
            {
                bindingSource1.Add(item);
            }
            dataGridView2.DataSource = bindingSource1; // призначаємо джерелом даних біндінгСорс
            txtBrand.DataBindings.Add("Text", bindingSource1, "Brand");
            txtCapacity.DataBindings.Add("Text", bindingSource1, "Capacity");
            txtModel.DataBindings.Add("Text", bindingSource1, "Model");

            //-----------------------------------
            // 3 спосіб
            dataSet = new DataSet("EmployeeDataSet"); // 3.1 створити ДатаСет
            DataTable table = CreateTable(); // 3.2 створити структуру таблицю
            dataSet.Tables.Add(table);  // 3.3. додати таблицю в датаСет
            FillTable(dataSet.Tables[0]);

            dataGridView3.DataSource = dataSet.Tables[0];
        }

        private void FillTable(DataTable dataTable)
        {
            if (File.Exists("Employee.xml"))
            {
                dataSet.ReadXml("Employee.xml");
            }
            else
            {
                Employees emp = new Employees();
                foreach (Employee item in emp)
                {
                    dataTable.Rows.Add(item.Id, item.Name, item.Salary);
                }
            }
        }

        private DataTable CreateTable()
        {
            DataTable table = new DataTable("EmployeesTable");
            DataColumn primaryKey = null;
            table.Columns.Add(primaryKey = new DataColumn("Id", typeof(int)));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Salary", typeof(int));

            table.PrimaryKey = new DataColumn[] { primaryKey }; // колонка primaryKey буде містити унікальні ключові значення
            return table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                tbAuthor.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                tbTitle.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                cbAvailable.Checked = (bool)dataGridView1.Rows[row].Cells[2].Value;
            }
            catch (Exception ex) // клік на незаповненому рядку  таблиці
            {
                tbAuthor.Text = tbTitle.Text = "";
                dataGridView1.EndEdit(); // припиняємо редагування
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripStatusLabel1.Text = $"U clicked in ({e.RowIndex}, {e.ColumnIndex})";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataSet.WriteXml("Employee.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbId.Text) ||
                String.IsNullOrWhiteSpace(tbName.Text) ||
                String.IsNullOrWhiteSpace(tbSalary.Text))
                return;

            bool isParsedID = int.TryParse(tbId.Text, out int id);
            bool isParsedName = tbName.Text.Any(x => char.IsDigit(x));
            bool isParsedSalary = int.TryParse(tbSalary.Text, out int salary);

            // Перевірка чи є в таблиці ID
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (row[0].ToString().Equals(id.ToString()))
                {
                    isParsedID = false;
                    break;
                }
            }

            if (isParsedID && !isParsedName && isParsedSalary)
            {
                dataSet.Tables[0].Rows.Add(id, tbName.Text, salary);
            }

        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
                MessageBox.Show("Id must be unique and typeof int");
            else
                MessageBox.Show("Bad Value for int salary");
                
        }
    }
}
