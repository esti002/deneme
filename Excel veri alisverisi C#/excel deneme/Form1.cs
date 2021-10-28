using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel_deneme
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile();

        }

        public void openFile()
        {
            Excel excel = new Excel(@"C:\Users\Mehmet ESTİ\OneDrive\Kitap1.xlsx", 1);
            MessageBox.Show(excel.ReadCell(0,0));
            excel.closeWb();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Excel excel = new Excel(@"C:\Users\Mehmet ESTİ\OneDrive\Kitap1.xlsx", 1);
            excel.WriteCell(5, 6, textBox1.Text);
            MessageBox.Show("veriler guncellendi.");
            excel.closeWb();
            

        }
    }
}
