using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cSharpWinForm
{
    public partial class shopRegistration : UserControl
    {
        int pageNo = 0;
        accessingDB accesDB = new accessingDB();
        public shopRegistration()
        {
            InitializeComponent();
        }

        private void shopRegistration_Load(object sender, EventArgs e)
        {
            dgwTable.DataSource = accesDB.GetAll();
        }


        private void dgwTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            monthAnalysePanel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            analyseResultGB2.Show();
            int totalSpend_Y = 0;
            showInfoPanel.Show();

            int validYear = Convert.ToInt32(analyseYear1.Text);

            accesDB.yearAnalyser(validYear, ref totalSpend_Y);
            yearResultsLB.Text = analyseYear1.Text.ToString()+" yilinda yapilan toplam harcama : "+ Convert.ToString(totalSpend_Y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            analyseResultsGB.Show();
            int validYear = Convert.ToInt32(analyseYear2.Text);
            int validMonth = Convert.ToInt32(analyseMonth.Text);

            int totalSpend_M = 0;

            accesDB.monthAnalyser(validYear, validMonth, ref totalSpend_M);
            monthResultLB1.Text =Convert.ToString( totalSpend_M);



        }

        private void button6_Click(object sender, EventArgs e)
        {
            yearAnalysePanel.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            monthAnalysePanel.Hide();
            analyseYear2.Clear();
            analyseMonth.Clear();
            analyseResultsGB.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yearAnalysePanel.Hide();
            analyseYear1.Clear();
            analyseResultGB2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pageNo != 2)
            {
                hider(pageNo);
                pageNo = 2;
            }
            updateDataPanel1.Show();


        }

        void hider(int pageNum)
        {
            switch (pageNum)
            {
                case 1:
                    showInfoPanel.Hide();
                    yearAnalysePanel.Hide();
                    monthAnalysePanel.Hide();
                    break;
                case 2:
                    updateDataPanel1.Hide();
                    break;
                case 3:
                    createDataPanel.Hide();
                    break;
                case 4:
                    deletePanel.Hide();
                    break;
            }
        }

        private void showInfo_Click(object sender, EventArgs e)
        {
            if (pageNo != 1)
            {
                showInfoPanel.Show();
                hider(pageNo);
                pageNo = 1;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = productNameTB.Text;
            int getYear = System.Convert.ToInt32(getYearTB.Text);
            int getMonth = System.Convert.ToInt32(getMonthTB.Text);
            int getDay = System.Convert.ToInt32(getDayTB.Text);
            int productPrice = System.Convert.ToInt32(productPriceTB.Text);


            accesDB.addNewShopping(productName, getYear, getMonth, getDay, productPrice);

            MessageBox.Show("VERITABANINA KAYIT YAPILDI.");

            dgwTable.DataSource = accesDB.GetAll();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageNo != 3)
            {
                hider(pageNo);
                pageNo = 3;
                createDataPanel.Show();
            }
        
        }

        private void dgwTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gorunmezIdLabel.Text = dgwTable.CurrentRow.Cells[0].Value.ToString();
            idTB.Text = dgwTable.CurrentRow.Cells[0].Value.ToString();
            newProductNameTB.Text = dgwTable.CurrentRow.Cells[1].Value.ToString();
            newGetYearTB.Text = dgwTable.CurrentRow.Cells[2].Value.ToString();
            newGetMonthTB.Text = dgwTable.CurrentRow.Cells[3].Value.ToString();
            newGetDayTB.Text = dgwTable.CurrentRow.Cells[4].Value.ToString();
            newProductPriceTB.Text = dgwTable.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = System.Convert.ToInt32(gorunmezIdLabel.Text);
            string ProductName = newProductNameTB.Text;
            int getYear = System.Convert.ToInt32(newGetYearTB.Text);
            int getMonth = System.Convert.ToInt32(newGetMonthTB.Text);
            int getDay = System.Convert.ToInt32(newGetDayTB.Text);
            int productPrice = System.Convert.ToInt32(newProductPriceTB.Text);

            accesDB.updateData(id,ProductName, getYear, getMonth, getDay, productPrice);

            dgwTable.DataSource = accesDB.GetAll();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int id =System.Convert.ToInt32(idTB.Text); 
            DialogResult dialogResult = MessageBox.Show("Bu kaydi silmek istediginize emin misiniz?", "SILMEYI ONAYLA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                accesDB.deleteData(id);
            }
            dgwTable.DataSource = accesDB.GetAll();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pageNo != 4)
            {
                hider(pageNo);
                pageNo = 4;
                deletePanel.Show();
            }
        }
    }
}
