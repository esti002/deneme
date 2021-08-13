using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cSharpWinForm
{
    public partial class homePage : UserControl
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infoLabel1.Hide();
            infoLabel2.Hide();
            yesButton.Hide();
            noButton.Hide();
            infoLabel3.Show();
            ok1.Show();
            ok2.Show();
            ok3.Show();
            nextButton.Show();
        }

        int nextClickNo = 0;
        private void nextButton_Click(object sender, EventArgs e)
        {
            nextClickNo++;
            if (nextClickNo == 1)
            {
                infoLabel3.Hide();
                ok1.Hide();
                ok2.Hide();
                ok3.Hide();
                nextButton.Show();
                infoLabel4.Show();
                ok4.Show();
            }
            if (nextClickNo == 2)
            {
                infoLabel4.Hide();
                ok4.Hide();
                infoLabel5.Show();
                ok5.Show();
            }
            if (nextClickNo == 3)
            {
                infoLabel5.Hide();
                ok5.Hide();
            }
            if (nextClickNo == 3)
            {
                nextButton.Hide();
                infoLabel1.Show();
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            infoLabel2.Hide();
            yesButton.Hide();
            noButton.Hide();
        }
    }
}
