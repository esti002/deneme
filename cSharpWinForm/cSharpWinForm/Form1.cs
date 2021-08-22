using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpWinForm
{
    public partial class Form1 : Form
    {

        int pageNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            if (pageNumber != 0)
            {
                hider(pageNumber);
            }
            homePageButton.BackColor = System.Drawing.Color.Blue;
            pageNumber = 0;
            homePage2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dateProcessButton_Click(object sender, EventArgs e)
        {
            
            if (pageNumber != 1)
            {
                hider(pageNumber);
                dateProcessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            pageNumber = 1;
            dateProcess.Show();
        }

        void hider(int pageNo) 
        {
            switch (pageNo) 
            {
                case 0:
                    homePage2.Hide();
                    homePageButton.BackColor = System.Drawing.Color.Transparent;
                    break;
                case 1:
                    dateProcess.Hide();
                    dateProcessButton.BackColor = System.Drawing.Color.Transparent;
                    break;
                case 2:
                    aboutPage1.Hide();
                    aboutButton.BackColor = System.Drawing.Color.Transparent;
                    break;
                case 3:
                    shopRegistration1.Hide();
                    marketButton.BackColor = System.Drawing.Color.Transparent;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pageNumber != 2)
            {
                hider(pageNumber);
                aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            }
            pageNumber = 2;
            aboutPage1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pageNumber != 3)
            {
                hider(pageNumber);
                marketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            }
            pageNumber = 3;
            shopRegistration1.Show();
        }
    }
}
