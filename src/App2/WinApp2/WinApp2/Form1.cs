using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("app2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = 2000;
            DateTime date1 = new DateTime(year, 2, 26);
            DateTime date2 = new DateTime(year, 2, DateTime.DaysInMonth(year, 2));
            DateTime date3 = new DateTime(year, 3, 1);
            DateTime date4 = new DateTime(year, 3, 2);
            DateTime date5 = DateTime.Now;
            DateTime date6 = DateTime.Now.AddHours(-2.0);
            DateTime date7 = DateTime.Now.AddHours(13.0);
            DateTime date8 = DateTime.Now.AddYears(-1);

            System.TimeSpan diff1 = date3.Subtract(date2);
            diff1= date2.Subtract(date1);
            diff1 = date4.Subtract(date3);

            //Negativ?
            diff1 = date2.Subtract(date3);
            diff1 = date1.Subtract(date2);

            diff1 = date6.Subtract(date5);
            diff1 = date5.Subtract(date6);

            diff1 = date8.Subtract(date5);

            int diffDay = date3.DayOfYear - date2.DayOfYear;
            diffDay = date2.DayOfYear - date1.DayOfYear;
            diffDay = date4.DayOfYear - date3.DayOfYear;

            diffDay = date2.DayOfYear - date3.DayOfYear;

            diffDay = date5.DayOfYear - date6.DayOfYear;
            diffDay = date7.DayOfYear - date6.DayOfYear;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Branch level 2");

        }
    }
}
