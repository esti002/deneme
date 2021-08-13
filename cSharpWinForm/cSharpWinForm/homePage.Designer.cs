
namespace cSharpWinForm
{
    partial class homePage
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
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Label();
            this.ok2 = new System.Windows.Forms.Label();
            this.ok3 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel4 = new System.Windows.Forms.Label();
            this.ok4 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.infoLabel5 = new System.Windows.Forms.Label();
            this.ok5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel2
            // 
            this.infoLabel2.AllowDrop = true;
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel2.Location = new System.Drawing.Point(174, 222);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(820, 76);
            this.infoLabel2.TabIndex = 1;
            this.infoLabel2.Text = "PROGRAMI KULLAMAK HAKKINDA YETERLI\r\nBILGIYE SAHIP DEGILSENIZ OGRETICIYI KULLANABI" +
    "LIRSINIZ.";
            // 
            // infoLabel1
            // 
            this.infoLabel1.AllowDrop = true;
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel1.Location = new System.Drawing.Point(174, 80);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(731, 76);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "MERHABALAR BU PROGRAM MEHMET ESTI \r\nTARAFINDAN GELISTIRILEN BIR DENEME PROJESIDIR" +
    ".\r\n";
            // 
            // ok1
            // 
            this.ok1.AutoSize = true;
            this.ok1.BackColor = System.Drawing.Color.Transparent;
            this.ok1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok1.Image = global::cSharpWinForm.Properties.Resources.okRed;
            this.ok1.Location = new System.Drawing.Point(3, 0);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(165, 80);
            this.ok1.TabIndex = 2;
            this.ok1.Text = "                                       \r\n\r\n\r\n\r\n";
            this.ok1.Visible = false;
            // 
            // ok2
            // 
            this.ok2.AutoSize = true;
            this.ok2.BackColor = System.Drawing.Color.Transparent;
            this.ok2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok2.Image = global::cSharpWinForm.Properties.Resources.okWhite;
            this.ok2.Location = new System.Drawing.Point(3, 80);
            this.ok2.Name = "ok2";
            this.ok2.Size = new System.Drawing.Size(165, 80);
            this.ok2.TabIndex = 3;
            this.ok2.Text = "                                       \r\n\r\n\r\n\r\n";
            this.ok2.Visible = false;
            // 
            // ok3
            // 
            this.ok3.AutoSize = true;
            this.ok3.BackColor = System.Drawing.Color.Transparent;
            this.ok3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok3.Image = global::cSharpWinForm.Properties.Resources.okYellow;
            this.ok3.Location = new System.Drawing.Point(0, 160);
            this.ok3.Name = "ok3";
            this.ok3.Size = new System.Drawing.Size(165, 80);
            this.ok3.TabIndex = 4;
            this.ok3.Text = "                                       \r\n\r\n\r\n\r\n";
            this.ok3.Visible = false;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Transparent;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Location = new System.Drawing.Point(254, 343);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(183, 29);
            this.yesButton.TabIndex = 5;
            this.yesButton.Text = "OGRETICIYI GEC";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Transparent;
            this.noButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Location = new System.Drawing.Point(552, 343);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(183, 29);
            this.noButton.TabIndex = 6;
            this.noButton.Text = "OGRETICIYI BASLAT";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel3.Image = global::cSharpWinForm.Properties.Resources.messageBox;
            this.infoLabel3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoLabel3.Location = new System.Drawing.Point(149, 0);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(206, 140);
            this.infoLabel3.TabIndex = 7;
            this.infoLabel3.Text = "          Oklarla gosterilen \r\n          yerdeki menuden\r\n          araclar arasi" +
    "nda\r\n          kolayca gezinebilirsin.   \r\n\r\n\r\n\r\n";
            this.infoLabel3.Visible = false;
            // 
            // infoLabel4
            // 
            this.infoLabel4.AutoSize = true;
            this.infoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel4.Image = global::cSharpWinForm.Properties.Resources.messageBox;
            this.infoLabel4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoLabel4.Location = new System.Drawing.Point(150, 417);
            this.infoLabel4.Name = "infoLabel4";
            this.infoLabel4.Size = new System.Drawing.Size(205, 180);
            this.infoLabel4.TabIndex = 8;
            this.infoLabel4.Text = "         Program hakkinda\r\n         daha detayli bilgi almak\r\n         istersen o" +
    "k ile gosterilen\r\n         hakkinda bolumune\r\n         gidebilirsin.\r\n\r\n\r\n\r\n\r\n";
            this.infoLabel4.Visible = false;
            // 
            // ok4
            // 
            this.ok4.AutoSize = true;
            this.ok4.BackColor = System.Drawing.Color.Transparent;
            this.ok4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok4.Image = global::cSharpWinForm.Properties.Resources.ok;
            this.ok4.Location = new System.Drawing.Point(0, 564);
            this.ok4.Name = "ok4";
            this.ok4.Size = new System.Drawing.Size(165, 80);
            this.ok4.TabIndex = 9;
            this.ok4.Text = "                                       \r\n\r\n\r\n\r\n";
            this.ok4.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Green;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(821, 564);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(113, 50);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "ILERI";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // infoLabel5
            // 
            this.infoLabel5.AutoSize = true;
            this.infoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel5.Image = global::cSharpWinForm.Properties.Resources.messageBox;
            this.infoLabel5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoLabel5.Location = new System.Drawing.Point(138, 538);
            this.infoLabel5.Name = "infoLabel5";
            this.infoLabel5.Size = new System.Drawing.Size(190, 200);
            this.infoLabel5.TabIndex = 11;
            this.infoLabel5.Text = "         Programin calismasini\r\n         sona erdirmek icin\r\n         ok ile beli" +
    "rtilen\r\n         butonu kullan.\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.infoLabel5.Visible = false;
            // 
            // ok5
            // 
            this.ok5.AutoSize = true;
            this.ok5.BackColor = System.Drawing.Color.Transparent;
            this.ok5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok5.Image = global::cSharpWinForm.Properties.Resources.okRed;
            this.ok5.Location = new System.Drawing.Point(0, 620);
            this.ok5.Name = "ok5";
            this.ok5.Size = new System.Drawing.Size(165, 80);
            this.ok5.TabIndex = 12;
            this.ok5.Text = "                                       \r\n\r\n\r\n\r\n";
            this.ok5.Visible = false;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cSharpWinForm.Properties.Resources.blue_1100x700;
            this.Controls.Add(this.ok5);
            this.Controls.Add(this.infoLabel5);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ok4);
            this.Controls.Add(this.infoLabel4);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.ok3);
            this.Controls.Add(this.ok2);
            this.Controls.Add(this.ok1);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Name = "homePage";
            this.Size = new System.Drawing.Size(1100, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label ok1;
        private System.Windows.Forms.Label ok2;
        private System.Windows.Forms.Label ok3;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel4;
        private System.Windows.Forms.Label ok4;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label infoLabel5;
        private System.Windows.Forms.Label ok5;
    }
}
