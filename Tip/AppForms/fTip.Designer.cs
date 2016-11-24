namespace Tip.AppForms
{
    partial class fTip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTip));
            this.lbPronounce = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.timerAutoTip = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntHide = new System.Windows.Forms.Button();
            this.btnHideMean = new System.Windows.Forms.Button();
            this.lbStt = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTiepTheo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbEx = new System.Windows.Forms.RichTextBox();
            this.lbLearnWord = new System.Windows.Forms.RichTextBox();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPronounce
            // 
            this.lbPronounce.AutoSize = true;
            this.lbPronounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPronounce.ForeColor = System.Drawing.Color.Maroon;
            this.lbPronounce.Location = new System.Drawing.Point(142, 18);
            this.lbPronounce.Name = "lbPronounce";
            this.lbPronounce.Size = new System.Drawing.Size(59, 13);
            this.lbPronounce.TabIndex = 2;
            this.lbPronounce.Text = "Pronounce";
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMean.ForeColor = System.Drawing.Color.Purple;
            this.lbMean.Location = new System.Drawing.Point(4, 96);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(42, 16);
            this.lbMean.TabIndex = 3;
            this.lbMean.Text = "Mean";
            // 
            // timerAutoTip
            // 
            this.timerAutoTip.Tick += new System.EventHandler(this.timerAutoTip_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(173, 92);
            // 
            // formMainToolStripMenuItem
            // 
            this.formMainToolStripMenuItem.Name = "formMainToolStripMenuItem";
            this.formMainToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.formMainToolStripMenuItem.Text = "Data Manager";
            this.formMainToolStripMenuItem.Click += new System.EventHandler(this.formMainToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.optionToolStripMenuItem.Text = "Option Auto Learn";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShowShortcutKeys = false;
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bntHide
            // 
            this.bntHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.bntHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHide.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHide.ForeColor = System.Drawing.Color.White;
            this.bntHide.Location = new System.Drawing.Point(0, 0);
            this.bntHide.Name = "bntHide";
            this.bntHide.Size = new System.Drawing.Size(401, 15);
            this.bntHide.TabIndex = 25;
            this.bntHide.UseVisualStyleBackColor = false;
            this.bntHide.Click += new System.EventHandler(this.bntHide_Click);
            this.bntHide.MouseHover += new System.EventHandler(this.bntHide_MouseHover);
            // 
            // btnHideMean
            // 
            this.btnHideMean.Location = new System.Drawing.Point(272, 97);
            this.btnHideMean.Name = "btnHideMean";
            this.btnHideMean.Size = new System.Drawing.Size(31, 24);
            this.btnHideMean.TabIndex = 26;
            this.btnHideMean.Text = "ẩn";
            this.btnHideMean.UseVisualStyleBackColor = true;
            this.btnHideMean.Click += new System.EventHandler(this.btnHideMean_Click);
            // 
            // lbStt
            // 
            this.lbStt.AutoSize = true;
            this.lbStt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbStt.Location = new System.Drawing.Point(5, 16);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(20, 13);
            this.lbStt.TabIndex = 27;
            this.lbStt.Text = "Stt";
            this.lbStt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(230, 97);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(41, 24);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(336, 97);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(30, 24);
            this.btnQuayLai.TabIndex = 30;
            this.btnQuayLai.Text = "<";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.Location = new System.Drawing.Point(367, 97);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(28, 24);
            this.btnTiepTheo.TabIndex = 29;
            this.btnTiepTheo.Text = ">";
            this.btnTiepTheo.UseVisualStyleBackColor = true;
            this.btnTiepTheo.Click += new System.EventHandler(this.btnTiepTheo_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(305, 97);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(30, 24);
            this.btnStart.TabIndex = 31;
            this.btnStart.Text = "<<";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(217, 15);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(180, 83);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lbEx
            // 
            this.lbEx.BackColor = System.Drawing.SystemColors.Control;
            this.lbEx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbEx.Location = new System.Drawing.Point(37, 16);
            this.lbEx.Name = "lbEx";
            this.lbEx.Size = new System.Drawing.Size(73, 18);
            this.lbEx.TabIndex = 34;
            this.lbEx.Text = "Ex";
            // 
            // lbLearnWord
            // 
            this.lbLearnWord.BackColor = System.Drawing.SystemColors.Control;
            this.lbLearnWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLearnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLearnWord.ForeColor = System.Drawing.Color.Green;
            this.lbLearnWord.Location = new System.Drawing.Point(0, 33);
            this.lbLearnWord.Name = "lbLearnWord";
            this.lbLearnWord.Size = new System.Drawing.Size(211, 65);
            this.lbLearnWord.TabIndex = 35;
            this.lbLearnWord.Text = "Word";
            // 
            // fTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 122);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.lbEx);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.lbPronounce);
            this.Controls.Add(this.lbLearnWord);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnTiepTheo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.btnHideMean);
            this.Controls.Add(this.bntHide);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTip";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tip Now......";
            this.Load += new System.EventHandler(this.fTip_Load);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbPronounce;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Timer timerAutoTip;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem formMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bntHide;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Button btnHideMean;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnTiepTheo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox lbEx;
        private System.Windows.Forms.RichTextBox lbLearnWord;
    }
}