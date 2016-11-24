namespace Tip.AppForms
{
    partial class fAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAbout));
            this.rtext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blNameProducts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDeverloper = new System.Windows.Forms.Label();
            this.grbInfoSoft = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkFace = new System.Windows.Forms.LinkLabel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbYahoo = new System.Windows.Forms.Label();
            this.lbBuildday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDevApp = new System.Windows.Forms.GroupBox();
            this.lbDsSoft = new System.Windows.Forms.Label();
            this.linkDsSoft = new System.Windows.Forms.LinkLabel();
            this.grbInfoSoft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDevApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtext
            // 
            this.rtext.BackColor = System.Drawing.SystemColors.Control;
            this.rtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtext.Location = new System.Drawing.Point(3, 16);
            this.rtext.Name = "rtext";
            this.rtext.Size = new System.Drawing.Size(349, 230);
            this.rtext.TabIndex = 0;
            this.rtext.Text = resources.GetString("rtext.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software:";
            // 
            // blNameProducts
            // 
            this.blNameProducts.AutoSize = true;
            this.blNameProducts.Location = new System.Drawing.Point(110, 140);
            this.blNameProducts.Name = "blNameProducts";
            this.blNameProducts.Size = new System.Drawing.Size(40, 13);
            this.blNameProducts.TabIndex = 1;
            this.blNameProducts.Text = "Tip 1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Developer: ";
            // 
            // lbDeverloper
            // 
            this.lbDeverloper.AutoSize = true;
            this.lbDeverloper.Location = new System.Drawing.Point(110, 160);
            this.lbDeverloper.Name = "lbDeverloper";
            this.lbDeverloper.Size = new System.Drawing.Size(49, 13);
            this.lbDeverloper.TabIndex = 3;
            this.lbDeverloper.Text = "Đức Sơn";
            // 
            // grbInfoSoft
            // 
            this.grbInfoSoft.Controls.Add(this.linkDsSoft);
            this.grbInfoSoft.Controls.Add(this.lbDsSoft);
            this.grbInfoSoft.Controls.Add(this.pictureBox1);
            this.grbInfoSoft.Controls.Add(this.linkFace);
            this.grbInfoSoft.Controls.Add(this.label1);
            this.grbInfoSoft.Controls.Add(this.blNameProducts);
            this.grbInfoSoft.Controls.Add(this.lbEmail);
            this.grbInfoSoft.Controls.Add(this.label4);
            this.grbInfoSoft.Controls.Add(this.label10);
            this.grbInfoSoft.Controls.Add(this.lbDeverloper);
            this.grbInfoSoft.Controls.Add(this.lbYahoo);
            this.grbInfoSoft.Controls.Add(this.lbBuildday);
            this.grbInfoSoft.Controls.Add(this.label7);
            this.grbInfoSoft.Controls.Add(this.label6);
            this.grbInfoSoft.Location = new System.Drawing.Point(6, 12);
            this.grbInfoSoft.Name = "grbInfoSoft";
            this.grbInfoSoft.Size = new System.Drawing.Size(246, 254);
            this.grbInfoSoft.TabIndex = 16;
            this.grbInfoSoft.TabStop = false;
            this.grbInfoSoft.Text = "Về tôi";
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tip.Properties.Resources.iconAbout;
            this.pictureBox1.Location = new System.Drawing.Point(80, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // linkFace
            // 
            this.linkFace.AutoSize = true;
            this.linkFace.Location = new System.Drawing.Point(31, 231);
            this.linkFace.Name = "linkFace";
            this.linkFace.Size = new System.Drawing.Size(193, 13);
            this.linkFace.TabIndex = 13;
            this.linkFace.TabStop = true;
            this.linkFace.Text = "http://www.facebook.com/stone89son";
            this.linkFace.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFace_LinkClicked);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(110, 196);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(97, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "itvntbu@gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email:";
            // 
            // lbYahoo
            // 
            this.lbYahoo.AutoSize = true;
            this.lbYahoo.Location = new System.Drawing.Point(110, 177);
            this.lbYahoo.Name = "lbYahoo";
            this.lbYahoo.Size = new System.Drawing.Size(86, 13);
            this.lbYahoo.TabIndex = 9;
            this.lbYahoo.Text = "khoahocvietnam";
            // 
            // lbBuildday
            // 
            this.lbBuildday.AutoSize = true;
            this.lbBuildday.Location = new System.Drawing.Point(31, 213);
            this.lbBuildday.Name = "lbBuildday";
            this.lbBuildday.Size = new System.Drawing.Size(45, 13);
            this.lbBuildday.TabIndex = 4;
            this.lbBuildday.Text = "Update:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yahoo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "27/07/2013";
            // 
            // gbDevApp
            // 
            this.gbDevApp.Controls.Add(this.rtext);
            this.gbDevApp.Location = new System.Drawing.Point(264, 17);
            this.gbDevApp.Name = "gbDevApp";
            this.gbDevApp.Size = new System.Drawing.Size(355, 249);
            this.gbDevApp.TabIndex = 17;
            this.gbDevApp.TabStop = false;
            this.gbDevApp.Text = "Phát triển ứng dụng Tip v1.0";
            // 
            // lbDsSoft
            // 
            this.lbDsSoft.AutoSize = true;
            this.lbDsSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsSoft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbDsSoft.Location = new System.Drawing.Point(12, 24);
            this.lbDsSoft.Name = "lbDsSoft";
            this.lbDsSoft.Size = new System.Drawing.Size(221, 24);
            this.lbDsSoft.TabIndex = 15;
            this.lbDsSoft.Text = "Duc Son Software Center";
            this.lbDsSoft.Click += new System.EventHandler(this.lbDsSoft_Click);
            // 
            // linkDsSoft
            // 
            this.linkDsSoft.AutoSize = true;
            this.linkDsSoft.Location = new System.Drawing.Point(20, 51);
            this.linkDsSoft.Name = "linkDsSoft";
            this.linkDsSoft.Size = new System.Drawing.Size(200, 13);
            this.linkDsSoft.TabIndex = 16;
            this.linkDsSoft.TabStop = true;
            this.linkDsSoft.Text = "https://www.facebook.com/DSSoftware";
            this.linkDsSoft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDsSoft_LinkClicked);
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 284);
            this.Controls.Add(this.grbInfoSoft);
            this.Controls.Add(this.gbDevApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhà phát triển";
            this.Load += new System.EventHandler(this.fAbout_Load);
            this.grbInfoSoft.ResumeLayout(false);
            this.grbInfoSoft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDevApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blNameProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDeverloper;
        private System.Windows.Forms.GroupBox grbInfoSoft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkFace;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbYahoo;
        private System.Windows.Forms.Label lbBuildday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDevApp;
        private System.Windows.Forms.Label lbDsSoft;
        private System.Windows.Forms.LinkLabel linkDsSoft;
    }
}