
namespace cSharpWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateProcessButton = new System.Windows.Forms.Button();
            this.homePageButton = new System.Windows.Forms.Button();
            this.aboutPage1 = new cSharpWinForm.aboutPage();
            this.dateProcess = new cSharpWinForm.dateProcess();
            this.homePage2 = new cSharpWinForm.homePage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dateProcessButton);
            this.panel1.Controls.Add(this.homePageButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 700);
            this.panel1.TabIndex = 0;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Transparent;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Image = global::cSharpWinForm.Properties.Resources.info1;
            this.aboutButton.Location = new System.Drawing.Point(0, 560);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(70, 70);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::cSharpWinForm.Properties.Resources.power_button_50x50;
            this.closeButton.Location = new System.Drawing.Point(0, 630);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(70, 70);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "button sablon";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dateProcessButton
            // 
            this.dateProcessButton.BackColor = System.Drawing.Color.Transparent;
            this.dateProcessButton.BackgroundImage = global::cSharpWinForm.Properties.Resources.takvim2;
            this.dateProcessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dateProcessButton.FlatAppearance.BorderSize = 0;
            this.dateProcessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateProcessButton.Location = new System.Drawing.Point(0, 70);
            this.dateProcessButton.Name = "dateProcessButton";
            this.dateProcessButton.Size = new System.Drawing.Size(70, 70);
            this.dateProcessButton.TabIndex = 1;
            this.dateProcessButton.UseVisualStyleBackColor = false;
            this.dateProcessButton.Click += new System.EventHandler(this.dateProcessButton_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.Blue;
            this.homePageButton.FlatAppearance.BorderSize = 0;
            this.homePageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePageButton.Image = global::cSharpWinForm.Properties.Resources.home_pace_icon;
            this.homePageButton.Location = new System.Drawing.Point(0, 0);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(70, 70);
            this.homePageButton.TabIndex = 0;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // aboutPage1
            // 
            this.aboutPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutPage1.BackgroundImage")));
            this.aboutPage1.Location = new System.Drawing.Point(70, 0);
            this.aboutPage1.Name = "aboutPage1";
            this.aboutPage1.Size = new System.Drawing.Size(1100, 700);
            this.aboutPage1.TabIndex = 5;
            this.aboutPage1.Visible = false;
            // 
            // dateProcess
            // 
            this.dateProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dateProcess.BackgroundImage")));
            this.dateProcess.Location = new System.Drawing.Point(70, 0);
            this.dateProcess.Name = "dateProcess";
            this.dateProcess.Size = new System.Drawing.Size(1100, 700);
            this.dateProcess.TabIndex = 1;
            this.dateProcess.Visible = false;
            // 
            // homePage2
            // 
            this.homePage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage2.BackgroundImage")));
            this.homePage2.Location = new System.Drawing.Point(70, 0);
            this.homePage2.Name = "homePage2";
            this.homePage2.Size = new System.Drawing.Size(1100, 700);
            this.homePage2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1170, 700);
            this.Controls.Add(this.homePage2);
            this.Controls.Add(this.dateProcess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aboutPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "COMBO";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homePageButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button dateProcessButton;
        private homePage homePage1;
        private dateProcess dateProcess;
        private homePage homePage2;
        private System.Windows.Forms.Button aboutButton;
        private aboutPage aboutPage1;
    }
}

