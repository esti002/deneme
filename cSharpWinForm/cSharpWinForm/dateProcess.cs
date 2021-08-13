using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cSharpWinForm
{
    public partial class dateProcess : UserControl
    {
        iki_tarih_farki differenceCal = new iki_tarih_farki();
        gun_sayisi_tarih_iliskisi dayPasser = new gun_sayisi_tarih_iliskisi();

        public dateProcess()
        {
            InitializeComponent();
        }

        private void dateProcess1_Click(object sender, EventArgs e)
        {
            dateP1page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int year1 = System.Convert.ToInt16(year1TB.Text);
            int month1 = System.Convert.ToInt16(month1TB.Text);
            int day1 = System.Convert.ToInt16(day1TB.Text);
            int year2 = System.Convert.ToInt16(year2TB.Text);
            int month2 = System.Convert.ToInt16(month2TB.Text);
            int day2 = System.Convert.ToInt16(day2TB.Text);

            int result = 0;

            differenceCal.dateDifference(year1,month1,day1,year2,month2,day2,ref result);

            tarihlerLabel.Text ="GIRILEN TARIHLER :  "+ System.Convert.ToString(year1)+"/" + System.Convert.ToString(month1) + "/" + System.Convert.ToString(day1) + "      " +
                 System.Convert.ToString(year2) + "/" + System.Convert.ToString(month2) + "/" + System.Convert.ToString(day2);

            resultLabel1.Text = "ARADAKI GUN FARKI :  " + result;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int year1 = System.Convert.ToInt16(yearTB3.Text);
            int month1 = System.Convert.ToInt16(monthTB3.Text);
            int day1 = System.Convert.ToInt16(dayTB3.Text);

            int result = 0;

            int year2 = DateTime.Now.Year; 
            int month2= DateTime.Now.Month; 
            int day2= DateTime.Now.Day;

            differenceCal.dateDifference(year1, month1, day1, year2, month2, day2, ref result);

            dates2.Text = "GECERLI TARIHLER :  " + year1 + "/" + month1 + "/" + day1 + "     " + year2 + "/" + month2 + "/" + day2;

            resultLabel2.Text = "GIRDIGINIZ TARIH ILE BUGUN ARASINDAKI FARK :  " + result;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateP2page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateP2page.Hide();
            yearTB3.Clear();
            monthTB3.Clear();
            dayTB3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateP1page.Hide();
            year1TB.Clear();
            year2TB.Clear();
            month1TB.Clear();
            month2TB.Clear();
            day1TB.Clear();
            day2TB.Clear();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            int year = System.Convert.ToInt16(yearAllTB.Text);

            int month1 = System.Convert.ToInt16(monthTB4.Text);
            int day1 = System.Convert.ToInt16(dayTB4.Text);

            int month2 = System.Convert.ToInt16(monthTB5.Text);
            int day2 = System.Convert.ToInt16(dayTB5.Text);

            int result = 0;

            differenceCal.dateDifference(year, month1, day1, year, month2, day2, ref result);

            dateLabel3.Text = "GECERLI TARIHLER :  " + year + "/" + month1 + "/" + day1 + "     " + year + "/" + month2 + "/" + day2;
            resultLabel3.Text = "GIRDIGINIZ TARIHLER ARASINDAKI FARK :  " + result;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dateP3page.Hide();
            yearAllTB.Clear();
            monthTB4.Clear();
            dayTB4.Clear();
            monthTB5.Clear();
            dayTB5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateP3page.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int oldYear = System.Convert.ToInt16(yearTB6.Text);
            int oldMonth = System.Convert.ToInt16(monthTB6.Text);
            int oldDay = System.Convert.ToInt16(dayTB6.Text);

            int passDay = System.Convert.ToInt16(passDayTB.Text);

            int newYear = 0;
            int newMonth = 0;
            int newDay = 0;

            dayPasser.goForwardInDate(oldYear, oldMonth, oldDay, passDay,ref newYear,ref newMonth,ref newDay);

            dateLabel4.Text = "BASLANGIC TARIHI :  " + oldYear + "/" + oldMonth + "/" + oldDay;

            resultLabel4.Text = "YENI TARIH :  " + newYear + "/" + newMonth + "/" + newDay;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dateP4page.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dateP4page.Hide();

            yearTB6.Clear();
            monthTB6.Clear();
            dayTB6.Clear();
            passDayTB.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int oldYear = System.Convert.ToInt16(yearTB7.Text);
            int oldMonth = System.Convert.ToInt16(monthTB7.Text);
            int oldDay = System.Convert.ToInt16(dayTB7.Text);

            int backDay = System.Convert.ToInt16(backDayTB.Text);

            int newYear = 0;
            int newMonth = 0;
            int newDay = 0;

            dayPasser.goBackInDate(oldYear, oldMonth, oldDay, backDay, ref newYear, ref newMonth, ref newDay);

            dateLabel7.Text = "BASLANGIC TARIHI :  " + oldYear + "/" + oldMonth + "/" + oldDay;

            resultLabel7.Text = "YENI TARIH :  " + newYear + "/" + newMonth + "/" + newDay;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            dateP5page.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dateP5page.Hide();
            yearTB7.Clear();
            monthTB7.Clear();
            dayTB7.Clear();
            backDayTB.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dateP6Panel.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int oldYear = DateTime.Now.Year;
            int oldMonth = DateTime.Now.Month;
            int oldDay = DateTime.Now.Day;

            int backDay = System.Convert.ToInt16(forwardDayTB2.Text);

            int newYear = 0;
            int newMonth = 0;
            int newDay = 0;

            dayPasser.goForwardInDate(oldYear, oldMonth, oldDay, backDay, ref newYear, ref newMonth, ref newDay);

            dateLabel8.Text = "BASLANGIC TARIHI :  " + oldYear + "/" + oldMonth + "/" + oldDay;

            resultLabel8.Text = "YENI TARIH :  " + newYear + "/" + newMonth + "/" + newDay;



        }

        private void button17_Click(object sender, EventArgs e)
        {
            dateP6Panel.Hide();
            forwardDayTB2.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
