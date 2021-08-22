
namespace cSharpWinForm
{
    partial class shopRegistration
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.dgwTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.showInfo = new System.Windows.Forms.Button();
            this.updateDataPanel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.showInfoPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.monthAnalysePanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.analyseMonth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.analyseResultsGB = new System.Windows.Forms.GroupBox();
            this.monthResultLB2 = new System.Windows.Forms.Label();
            this.monthResultLB1 = new System.Windows.Forms.Label();
            this.analyseYear2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yearAnalysePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.analyseResultGB2 = new System.Windows.Forms.GroupBox();
            this.yearResultLB2 = new System.Windows.Forms.Label();
            this.yearResultsLB = new System.Windows.Forms.Label();
            this.analyseYear1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1LB1 = new System.Windows.Forms.Label();
            this.createDataPanel = new System.Windows.Forms.Panel();
            this.productPriceTB = new System.Windows.Forms.TextBox();
            this.getDayTB = new System.Windows.Forms.TextBox();
            this.getMonthTB = new System.Windows.Forms.TextBox();
            this.getYearTB = new System.Windows.Forms.TextBox();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createRecordButton = new System.Windows.Forms.Button();
            this.updateDataPanel1 = new System.Windows.Forms.Panel();
            this.gorunmezIdLabel = new System.Windows.Forms.Label();
            this.updateRecordButton = new System.Windows.Forms.Button();
            this.newProductPriceTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.newGetDayTB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.newGetMonthTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.newGetYearTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.newProductNameTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).BeginInit();
            this.showInfoPanel.SuspendLayout();
            this.monthAnalysePanel.SuspendLayout();
            this.analyseResultsGB.SuspendLayout();
            this.yearAnalysePanel.SuspendLayout();
            this.analyseResultGB2.SuspendLayout();
            this.createDataPanel.SuspendLayout();
            this.updateDataPanel1.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel1
            // 
            this.messageLabel1.AutoSize = true;
            this.messageLabel1.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel1.Location = new System.Drawing.Point(167, 29);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(460, 41);
            this.messageLabel1.TabIndex = 2;
            this.messageLabel1.Text = "ALISVERIS TAKIP UYGULAMASI";
            // 
            // dgwTable
            // 
            this.dgwTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTable.Location = new System.Drawing.Point(477, 192);
            this.dgwTable.Name = "dgwTable";
            this.dgwTable.RowHeadersWidth = 51;
            this.dgwTable.RowTemplate.Height = 29;
            this.dgwTable.Size = new System.Drawing.Size(623, 167);
            this.dgwTable.TabIndex = 1;
            this.dgwTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTable_CellClick);
            this.dgwTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "YAPMAK ISTEDIGINIZ ISLEMI SECINIZ";
            // 
            // showInfo
            // 
            this.showInfo.BackColor = System.Drawing.Color.Transparent;
            this.showInfo.FlatAppearance.BorderSize = 3;
            this.showInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInfo.Location = new System.Drawing.Point(103, 153);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(286, 54);
            this.showInfo.TabIndex = 4;
            this.showInfo.Text = "ONCEKI ALISVERIS KAYITLARI VE ANALIZLERI";
            this.showInfo.UseVisualStyleBackColor = false;
            this.showInfo.Click += new System.EventHandler(this.showInfo_Click);
            // 
            // updateDataPanel
            // 
            this.updateDataPanel.BackColor = System.Drawing.Color.Transparent;
            this.updateDataPanel.FlatAppearance.BorderSize = 3;
            this.updateDataPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDataPanel.Location = new System.Drawing.Point(103, 247);
            this.updateDataPanel.Name = "updateDataPanel";
            this.updateDataPanel.Size = new System.Drawing.Size(286, 54);
            this.updateDataPanel.TabIndex = 5;
            this.updateDataPanel.Text = "ONCEKI BIR ALISVERIS KAYDINI GUNCELLE";
            this.updateDataPanel.UseVisualStyleBackColor = false;
            this.updateDataPanel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(103, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "YENI ALISVERIS KAYDI OLUSTUR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(103, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(286, 54);
            this.button4.TabIndex = 9;
            this.button4.Text = "ALISVERIS KAYDI SIL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // showInfoPanel
            // 
            this.showInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.showInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showInfoPanel.Controls.Add(this.button6);
            this.showInfoPanel.Controls.Add(this.button5);
            this.showInfoPanel.Controls.Add(this.label2);
            this.showInfoPanel.Location = new System.Drawing.Point(480, 400);
            this.showInfoPanel.Name = "showInfoPanel";
            this.showInfoPanel.Size = new System.Drawing.Size(620, 300);
            this.showInfoPanel.TabIndex = 10;
            this.showInfoPanel.Visible = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 5;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(380, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 53);
            this.button6.TabIndex = 4;
            this.button6.Text = "YILLIK ANALIZ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(105, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 53);
            this.button5.TabIndex = 3;
            this.button5.Text = "AYLIK ANALIZ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "TABLOYU NASIL ANALIZ ETMEK ISTIYORSUNUZ?";
            // 
            // monthAnalysePanel
            // 
            this.monthAnalysePanel.BackColor = System.Drawing.Color.Transparent;
            this.monthAnalysePanel.Controls.Add(this.button9);
            this.monthAnalysePanel.Controls.Add(this.label10);
            this.monthAnalysePanel.Controls.Add(this.analyseMonth);
            this.monthAnalysePanel.Controls.Add(this.label7);
            this.monthAnalysePanel.Controls.Add(this.button8);
            this.monthAnalysePanel.Controls.Add(this.analyseResultsGB);
            this.monthAnalysePanel.Controls.Add(this.analyseYear2);
            this.monthAnalysePanel.Controls.Add(this.label6);
            this.monthAnalysePanel.Location = new System.Drawing.Point(480, 400);
            this.monthAnalysePanel.Name = "monthAnalysePanel";
            this.monthAnalysePanel.Size = new System.Drawing.Size(620, 300);
            this.monthAnalysePanel.TabIndex = 7;
            this.monthAnalysePanel.Visible = false;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::cSharpWinForm.Properties.Resources.borrow_icon;
            this.button9.Location = new System.Drawing.Point(1, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(208, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "AY :";
            // 
            // analyseMonth
            // 
            this.analyseMonth.Location = new System.Drawing.Point(208, 84);
            this.analyseMonth.Name = "analyseMonth";
            this.analyseMonth.Size = new System.Drawing.Size(125, 27);
            this.analyseMonth.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(77, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "YIL :";
            // 
            // button8
            // 
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(387, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 36);
            this.button8.TabIndex = 3;
            this.button8.Text = "ANALIZ ET";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // analyseResultsGB
            // 
            this.analyseResultsGB.Controls.Add(this.monthResultLB2);
            this.analyseResultsGB.Controls.Add(this.monthResultLB1);
            this.analyseResultsGB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analyseResultsGB.Location = new System.Drawing.Point(41, 115);
            this.analyseResultsGB.Name = "analyseResultsGB";
            this.analyseResultsGB.Size = new System.Drawing.Size(448, 141);
            this.analyseResultsGB.TabIndex = 2;
            this.analyseResultsGB.TabStop = false;
            this.analyseResultsGB.Text = "ANALIZ SONUCLARI";
            this.analyseResultsGB.Visible = false;
            // 
            // monthResultLB2
            // 
            this.monthResultLB2.AutoSize = true;
            this.monthResultLB2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthResultLB2.Location = new System.Drawing.Point(23, 68);
            this.monthResultLB2.Name = "monthResultLB2";
            this.monthResultLB2.Size = new System.Drawing.Size(185, 20);
            this.monthResultLB2.TabIndex = 1;
            this.monthResultLB2.Text = "gunluk ortalama harcama";
            // 
            // monthResultLB1
            // 
            this.monthResultLB1.AutoSize = true;
            this.monthResultLB1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthResultLB1.Location = new System.Drawing.Point(23, 28);
            this.monthResultLB1.Name = "monthResultLB1";
            this.monthResultLB1.Size = new System.Drawing.Size(120, 20);
            this.monthResultLB1.TabIndex = 0;
            this.monthResultLB1.Text = "toplam harcama";
            // 
            // analyseYear2
            // 
            this.analyseYear2.Location = new System.Drawing.Point(77, 84);
            this.analyseYear2.Name = "analyseYear2";
            this.analyseYear2.Size = new System.Drawing.Size(125, 27);
            this.analyseYear2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(77, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ANALIZ ETMEK ISTEDIGINIZ TARIHLERI GIRINIZ ";
            // 
            // yearAnalysePanel
            // 
            this.yearAnalysePanel.BackColor = System.Drawing.Color.Transparent;
            this.yearAnalysePanel.Controls.Add(this.button7);
            this.yearAnalysePanel.Controls.Add(this.button10);
            this.yearAnalysePanel.Controls.Add(this.analyseResultGB2);
            this.yearAnalysePanel.Controls.Add(this.analyseYear1);
            this.yearAnalysePanel.Controls.Add(this.label3);
            this.yearAnalysePanel.Location = new System.Drawing.Point(480, 400);
            this.yearAnalysePanel.Name = "yearAnalysePanel";
            this.yearAnalysePanel.Size = new System.Drawing.Size(620, 300);
            this.yearAnalysePanel.TabIndex = 6;
            this.yearAnalysePanel.Visible = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(297, 73);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 36);
            this.button7.TabIndex = 3;
            this.button7.Text = "ANALIZ ET";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::cSharpWinForm.Properties.Resources.borrow_icon;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 55);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // analyseResultGB2
            // 
            this.analyseResultGB2.Controls.Add(this.yearResultLB2);
            this.analyseResultGB2.Controls.Add(this.yearResultsLB);
            this.analyseResultGB2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analyseResultGB2.Location = new System.Drawing.Point(41, 115);
            this.analyseResultGB2.Name = "analyseResultGB2";
            this.analyseResultGB2.Size = new System.Drawing.Size(448, 141);
            this.analyseResultGB2.TabIndex = 2;
            this.analyseResultGB2.TabStop = false;
            this.analyseResultGB2.Text = "ANALIZ SONUCLARI";
            this.analyseResultGB2.Visible = false;
            // 
            // yearResultLB2
            // 
            this.yearResultLB2.AutoSize = true;
            this.yearResultLB2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearResultLB2.Location = new System.Drawing.Point(23, 68);
            this.yearResultLB2.Name = "yearResultLB2";
            this.yearResultLB2.Size = new System.Drawing.Size(185, 20);
            this.yearResultLB2.TabIndex = 1;
            this.yearResultLB2.Text = "gunluk ortalama harcama";
            // 
            // yearResultsLB
            // 
            this.yearResultsLB.AutoSize = true;
            this.yearResultsLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearResultsLB.Location = new System.Drawing.Point(23, 28);
            this.yearResultsLB.Name = "yearResultsLB";
            this.yearResultsLB.Size = new System.Drawing.Size(120, 20);
            this.yearResultsLB.TabIndex = 0;
            this.yearResultsLB.Text = "toplam harcama";
            // 
            // analyseYear1
            // 
            this.analyseYear1.Location = new System.Drawing.Point(77, 82);
            this.analyseYear1.Name = "analyseYear1";
            this.analyseYear1.Size = new System.Drawing.Size(125, 27);
            this.analyseYear1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(77, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ANALIZ ETMEK ISTEDIGINIZ YILI GIRINIZ ";
            // 
            // panel1LB1
            // 
            this.panel1LB1.AutoSize = true;
            this.panel1LB1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1LB1.Location = new System.Drawing.Point(477, 161);
            this.panel1LB1.Name = "panel1LB1";
            this.panel1LB1.Size = new System.Drawing.Size(204, 28);
            this.panel1LB1.TabIndex = 2;
            this.panel1LB1.Text = "ALISVERIS KAYITLARI";
            // 
            // createDataPanel
            // 
            this.createDataPanel.BackColor = System.Drawing.Color.Transparent;
            this.createDataPanel.Controls.Add(this.productPriceTB);
            this.createDataPanel.Controls.Add(this.getDayTB);
            this.createDataPanel.Controls.Add(this.getMonthTB);
            this.createDataPanel.Controls.Add(this.getYearTB);
            this.createDataPanel.Controls.Add(this.productNameTB);
            this.createDataPanel.Controls.Add(this.label11);
            this.createDataPanel.Controls.Add(this.label12);
            this.createDataPanel.Controls.Add(this.label9);
            this.createDataPanel.Controls.Add(this.label8);
            this.createDataPanel.Controls.Add(this.label5);
            this.createDataPanel.Controls.Add(this.label4);
            this.createDataPanel.Controls.Add(this.createRecordButton);
            this.createDataPanel.Location = new System.Drawing.Point(480, 400);
            this.createDataPanel.Name = "createDataPanel";
            this.createDataPanel.Size = new System.Drawing.Size(620, 300);
            this.createDataPanel.TabIndex = 9;
            this.createDataPanel.Visible = false;
            this.createDataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productPriceTB
            // 
            this.productPriceTB.Location = new System.Drawing.Point(241, 210);
            this.productPriceTB.Name = "productPriceTB";
            this.productPriceTB.Size = new System.Drawing.Size(125, 27);
            this.productPriceTB.TabIndex = 13;
            // 
            // getDayTB
            // 
            this.getDayTB.Location = new System.Drawing.Point(241, 177);
            this.getDayTB.Name = "getDayTB";
            this.getDayTB.Size = new System.Drawing.Size(125, 27);
            this.getDayTB.TabIndex = 12;
            // 
            // getMonthTB
            // 
            this.getMonthTB.Location = new System.Drawing.Point(241, 144);
            this.getMonthTB.Name = "getMonthTB";
            this.getMonthTB.Size = new System.Drawing.Size(125, 27);
            this.getMonthTB.TabIndex = 11;
            // 
            // getYearTB
            // 
            this.getYearTB.Location = new System.Drawing.Point(241, 111);
            this.getYearTB.Name = "getYearTB";
            this.getYearTB.Size = new System.Drawing.Size(125, 27);
            this.getYearTB.TabIndex = 10;
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(241, 77);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(125, 27);
            this.productNameTB.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(43, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "URUNUN FIYATI :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "ALINAN GUN :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(43, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "ALINAN AY :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "ALINAN YIL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "URUN ADI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "ALMIS OLDUGUNUZ URUNUN BILGILERINI GIRINIZ";
            // 
            // createRecordButton
            // 
            this.createRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.createRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRecordButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createRecordButton.Location = new System.Drawing.Point(400, 148);
            this.createRecordButton.Name = "createRecordButton";
            this.createRecordButton.Size = new System.Drawing.Size(150, 44);
            this.createRecordButton.TabIndex = 0;
            this.createRecordButton.Text = "KAYIT OLUSTUR";
            this.createRecordButton.UseVisualStyleBackColor = true;
            this.createRecordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateDataPanel1
            // 
            this.updateDataPanel1.BackColor = System.Drawing.Color.Transparent;
            this.updateDataPanel1.Controls.Add(this.gorunmezIdLabel);
            this.updateDataPanel1.Controls.Add(this.updateRecordButton);
            this.updateDataPanel1.Controls.Add(this.newProductPriceTB);
            this.updateDataPanel1.Controls.Add(this.label13);
            this.updateDataPanel1.Controls.Add(this.newGetDayTB);
            this.updateDataPanel1.Controls.Add(this.label18);
            this.updateDataPanel1.Controls.Add(this.newGetMonthTB);
            this.updateDataPanel1.Controls.Add(this.label17);
            this.updateDataPanel1.Controls.Add(this.newGetYearTB);
            this.updateDataPanel1.Controls.Add(this.label16);
            this.updateDataPanel1.Controls.Add(this.newProductNameTB);
            this.updateDataPanel1.Controls.Add(this.label15);
            this.updateDataPanel1.Controls.Add(this.label14);
            this.updateDataPanel1.Location = new System.Drawing.Point(480, 400);
            this.updateDataPanel1.Name = "updateDataPanel1";
            this.updateDataPanel1.Size = new System.Drawing.Size(620, 300);
            this.updateDataPanel1.TabIndex = 14;
            this.updateDataPanel1.Visible = false;
            // 
            // gorunmezIdLabel
            // 
            this.gorunmezIdLabel.AutoSize = true;
            this.gorunmezIdLabel.Location = new System.Drawing.Point(442, 113);
            this.gorunmezIdLabel.Name = "gorunmezIdLabel";
            this.gorunmezIdLabel.Size = new System.Drawing.Size(17, 20);
            this.gorunmezIdLabel.TabIndex = 24;
            this.gorunmezIdLabel.Text = "0";
            this.gorunmezIdLabel.Visible = false;
            // 
            // updateRecordButton
            // 
            this.updateRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.updateRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateRecordButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateRecordButton.Location = new System.Drawing.Point(399, 160);
            this.updateRecordButton.Name = "updateRecordButton";
            this.updateRecordButton.Size = new System.Drawing.Size(168, 44);
            this.updateRecordButton.TabIndex = 14;
            this.updateRecordButton.Text = "KAYDI GUNCELLE";
            this.updateRecordButton.UseVisualStyleBackColor = true;
            this.updateRecordButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // newProductPriceTB
            // 
            this.newProductPriceTB.Location = new System.Drawing.Point(238, 226);
            this.newProductPriceTB.Name = "newProductPriceTB";
            this.newProductPriceTB.Size = new System.Drawing.Size(125, 27);
            this.newProductPriceTB.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(16, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(531, 56);
            this.label13.TabIndex = 2;
            this.label13.Text = "YUKARIDAKI TABLODAN BILGILERINI GUNCELLEMEK\r\nISTEDIGINIZ KAYDI SECINIZ YA DA TEKE" +
    "R TEKER YAZINIZ.";
            // 
            // newGetDayTB
            // 
            this.newGetDayTB.Location = new System.Drawing.Point(238, 193);
            this.newGetDayTB.Name = "newGetDayTB";
            this.newGetDayTB.Size = new System.Drawing.Size(125, 27);
            this.newGetDayTB.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(40, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 14;
            this.label18.Text = "URUN ADI :";
            // 
            // newGetMonthTB
            // 
            this.newGetMonthTB.Location = new System.Drawing.Point(238, 160);
            this.newGetMonthTB.Name = "newGetMonthTB";
            this.newGetMonthTB.Size = new System.Drawing.Size(125, 27);
            this.newGetMonthTB.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(40, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 23);
            this.label17.TabIndex = 15;
            this.label17.Text = "ALINAN YIL :";
            // 
            // newGetYearTB
            // 
            this.newGetYearTB.Location = new System.Drawing.Point(238, 127);
            this.newGetYearTB.Name = "newGetYearTB";
            this.newGetYearTB.Size = new System.Drawing.Size(125, 27);
            this.newGetYearTB.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(40, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 23);
            this.label16.TabIndex = 16;
            this.label16.Text = "ALINAN AY :";
            // 
            // newProductNameTB
            // 
            this.newProductNameTB.Location = new System.Drawing.Point(238, 93);
            this.newProductNameTB.Name = "newProductNameTB";
            this.newProductNameTB.Size = new System.Drawing.Size(125, 27);
            this.newProductNameTB.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(40, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 23);
            this.label15.TabIndex = 17;
            this.label15.Text = "ALINAN GUN :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(40, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "URUNUN FIYATI :";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.Transparent;
            this.deletePanel.Controls.Add(this.button1);
            this.deletePanel.Controls.Add(this.label20);
            this.deletePanel.Controls.Add(this.idTB);
            this.deletePanel.Controls.Add(this.label19);
            this.deletePanel.Location = new System.Drawing.Point(480, 400);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(620, 300);
            this.deletePanel.TabIndex = 25;
            this.deletePanel.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(77, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "KAYDI SIL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(40, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 23);
            this.label20.TabIndex = 26;
            this.label20.Text = "Urunun ID\'si :";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(170, 131);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(125, 27);
            this.idTB.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(40, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(505, 56);
            this.label19.TabIndex = 3;
            this.label19.Text = "YUKARIDAKI TABLODAN KAYDINI SILMEK ISTEDIGINIZ\r\nKAYDI SECINIZ YA DA ID\'SINI GIRIN" +
    "IZ.";
            // 
            // shopRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cSharpWinForm.Properties.Resources.orange_1100x700;
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.updateDataPanel1);
            this.Controls.Add(this.panel1LB1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgwTable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.updateDataPanel);
            this.Controls.Add(this.showInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel1);
            this.Controls.Add(this.createDataPanel);
            this.Controls.Add(this.yearAnalysePanel);
            this.Controls.Add(this.monthAnalysePanel);
            this.Controls.Add(this.showInfoPanel);
            this.Name = "shopRegistration";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.shopRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTable)).EndInit();
            this.showInfoPanel.ResumeLayout(false);
            this.showInfoPanel.PerformLayout();
            this.monthAnalysePanel.ResumeLayout(false);
            this.monthAnalysePanel.PerformLayout();
            this.analyseResultsGB.ResumeLayout(false);
            this.analyseResultsGB.PerformLayout();
            this.yearAnalysePanel.ResumeLayout(false);
            this.yearAnalysePanel.PerformLayout();
            this.analyseResultGB2.ResumeLayout(false);
            this.analyseResultGB2.PerformLayout();
            this.createDataPanel.ResumeLayout(false);
            this.createDataPanel.PerformLayout();
            this.updateDataPanel1.ResumeLayout(false);
            this.updateDataPanel1.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.DataGridView dgwTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showInfo;
        private System.Windows.Forms.Button updateDataPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel showInfoPanel;
        private System.Windows.Forms.Label panel1LB1;
        private System.Windows.Forms.Panel yearAnalysePanel;
        private System.Windows.Forms.GroupBox analyseResultGB2;
        private System.Windows.Forms.Label yearResultLB2;
        private System.Windows.Forms.Label yearResultsLB;
        private System.Windows.Forms.TextBox analyseYear1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel monthAnalysePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox analyseMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox analyseResultsGB;
        private System.Windows.Forms.Label monthResultLB2;
        private System.Windows.Forms.Label monthResultLB1;
        private System.Windows.Forms.TextBox analyseYear2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel createDataPanel;
        private System.Windows.Forms.Button createRecordButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productPriceTB;
        private System.Windows.Forms.TextBox getDayTB;
        private System.Windows.Forms.TextBox getMonthTB;
        private System.Windows.Forms.TextBox getYearTB;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel updateDataPanel1;
        private System.Windows.Forms.Button updateRecordButton;
        private System.Windows.Forms.TextBox newProductPriceTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox newGetDayTB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox newGetMonthTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox newGetYearTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox newProductNameTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label gorunmezIdLabel;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label19;
    }
}
