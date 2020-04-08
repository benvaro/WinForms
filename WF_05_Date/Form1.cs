using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_05_Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string season = "";
            DateTime selectedDate = (sender as DateTimePicker).Value;
            if (selectedDate.Month >= 3 && selectedDate.Month <= 5)
                season = "Spring";
            else if (selectedDate.Month >= 6 && selectedDate.Month <= 8)
                season = "Summer";
            else if (selectedDate.Month >= 9 && selectedDate.Month <=11)
                season = "Autumn";
            else
                season = "Winter";

            this.lblSeason.Text = $"Season: {season}";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.lblTime.Text = "DateTimePicker changed. " + dateTimePicker2.Value.TimeOfDay;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.lblDate.Text = $"Start day: {e.Start.ToShortDateString()} " +
                                $"\nEnd day {e.End.ToShortDateString()}";
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Text = "DoubleClick " + e.Button + " coord " + e.Location;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Key Press " + e.KeyChar.ToString();
        }
    }
}
