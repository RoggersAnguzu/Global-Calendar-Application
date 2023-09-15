using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Globalization_And_Calenders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Globalization.GregorianCalendar g=new System.Globalization.GregorianCalendar();
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.textBox4.Text = g.GetDayOfWeek(DateTime.Now).ToString();   
            //N.B All the above is used to provide the date about the System

            //****************************************
            
            int x;
            int.TryParse(this.textBox2.Text, out x);
            this.label4.Text = month_num_to_name(x);
        }

        public string month_num_to_name(int month_num)
        {
            string y;
            switch (month_num)
            {
                case 1:
                    y = "January";
                    break;
                case 2:
                    y = "February";
                    break;
                case 3:
                    y = "March";
                    break;
                case 4:
                    y = "April";
                    break;
                case 5:
                    y = "May";
                    break;
                case 6:
                    y = "June";
                    break;
                case 7:
                    y = "July";
                    break;
                case 8:
                    y = "August";
                    break;
                case 9:
                    y = "September";
                    break;
                case 10:
                    y = "October";
                    break;
                case 11:
                    y = "November";
                    break;
                case 12:
                    y = "December";
                    break;
                default:
                    y = "Please Enter an Appropriate Number of Month";
                    break;
            }
            return y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.label6.Text = g.GetYear(DateTime.Now).ToString();
            this.label7.Text = g.GetMonth(DateTime.Now).ToString();
            this.label8.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.label9.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            int x;
            int.TryParse(this.label7.Text, out x);
            this.label7.Text = month_num_to_name(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Globalization.HebrewCalendar g;
            g = new System.Globalization.HebrewCalendar();
            this.textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.textBox4.Text = g.GetDayOfWeek(DateTime.Now).ToString();   
            //N.B All the above is used to provide the date about the System

            //****************************************
            
            int x;
            int.TryParse(this.textBox2.Text, out x);
            this.label4.Text = month_num_to_name(x);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Globalization.TaiwanCalendar g;
            g = new System.Globalization.TaiwanCalendar();
            this.textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.textBox4.Text = g.GetDayOfWeek(DateTime.Now).ToString();
        }
    }
}
