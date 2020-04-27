using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_13_DataSource
{
    public partial class Form1 : Form
    {
        List<ProgrammingLanguage> languages;
        public Form1()
        {
            InitializeComponent();

            languages = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage{Name="C++", Popularity=1},
                new ProgrammingLanguage{Name="C#", Popularity=2},
                new ProgrammingLanguage{Name="Java", Popularity=3},
                new ProgrammingLanguage{Name="Python", Popularity=4},
                new ProgrammingLanguage{Name="Perl", Popularity=5},
                new ProgrammingLanguage{Name="Objective C", Popularity=6},
                new ProgrammingLanguage{Name="JavaScript", Popularity=7},
                new ProgrammingLanguage{Name="Swift", Popularity=8},
                new ProgrammingLanguage{Name="PHP", Popularity=9}
            };

            lbProgramming.DataSource = languages;
            lbProgramming.DisplayMember = "Name";
            lbProgramming.ValueMember = "Popularity";
            ClearDataSource();
        }

        private void lbProgramming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProgramming.SelectedIndex == -1)
                return;
            ProgrammingLanguage temp = lbProgramming.SelectedItem as ProgrammingLanguage;
            tbName.Text = temp.Name;
            tbPopularity.Text = temp.Popularity.ToString();

            tbText.Text = lbProgramming.Text;
            tbValue.Text = lbProgramming.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text) ||
                String.IsNullOrWhiteSpace(tbPopularity.Text))
                return;
            int popularity;
            if (!int.TryParse(tbPopularity.Text, out popularity))
                return;
            var prog = languages.Find(x => x.Name == tbName.Text);
            if (prog != null)
                return;
            ProgrammingLanguage language = new ProgrammingLanguage
            {
                Name = tbName.Text,
                Popularity = popularity
            };
            languages.Add(language);

            ClearDataSource();
        }

        private void ClearDataSource()
        {
            lbProgramming.DataSource = null;
            lbProgramming.DataSource = languages;
            lbProgramming.DisplayMember = "Name";
            lbProgramming.ValueMember = "Popularity";
            lbProgramming.SelectedIndex = -1;
            lbProgramming.SelectedItem = null;
            tbName.Text = "";
            tbPopularity.Text = "";
        }
    }

    public class ProgrammingLanguage   // internal - public для своїх))) видимий в межах збірки
    {
        public string Name { get; set; }
        public int Popularity { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name} --- {Popularity}";
        //}
    }


    #region Test base ToString()
    class Person
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return "Name = " + Name;
        }
    }
    class Student : Person
    {
        public int Age { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n + {Age}";
        }
    } 
    #endregion
}
