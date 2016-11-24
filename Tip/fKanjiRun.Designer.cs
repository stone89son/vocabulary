namespace Tip
{
    partial class fKanjiRun
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
            this.lbKanji = new System.Windows.Forms.Label();
            this.lbHanViet = new System.Windows.Forms.Label();
            this.lbSound = new System.Windows.Forms.Label();
            this.tmKanjiRun = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKanji
            // 
            this.lbKanji.AutoSize = true;
            this.lbKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKanji.Location = new System.Drawing.Point(69, 107);
            this.lbKanji.Name = "lbKanji";
            this.lbKanji.Size = new System.Drawing.Size(508, 211);
            this.lbKanji.TabIndex = 0;
            this.lbKanji.Text = "Kanji";
            // 
            // lbHanViet
            // 
            this.lbHanViet.AutoSize = true;
            this.lbHanViet.ForeColor = System.Drawing.Color.Red;
            this.lbHanViet.Location = new System.Drawing.Point(117, 94);
            this.lbHanViet.Name = "lbHanViet";
            this.lbHanViet.Size = new System.Drawing.Size(47, 13);
            this.lbHanViet.TabIndex = 1;
            this.lbHanViet.Text = "Hán việt";
            // 
            // lbSound
            // 
            this.lbSound.AutoSize = true;
            this.lbSound.ForeColor = System.Drawing.Color.Red;
            this.lbSound.Location = new System.Drawing.Point(190, 94);
            this.lbSound.Name = "lbSound";
            this.lbSound.Size = new System.Drawing.Size(73, 13);
            this.lbSound.TabIndex = 2;
            this.lbSound.Text = "Cách phát âm";
            // 
            // tmKanjiRun
            // 
            this.tmKanjiRun.Tick += new System.EventHandler(this.tmKanjiRun_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tốc độ";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(70, 11);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.Value = 1;
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // fKanjiRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lbSound);
            this.Controls.Add(this.lbHanViet);
            this.Controls.Add(this.lbKanji);
            this.Name = "fKanjiRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run Kanji";
            this.Load += new System.EventHandler(this.fKanjiRun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKanji;
        private System.Windows.Forms.Label lbHanViet;
        private System.Windows.Forms.Label lbSound;
        private System.Windows.Forms.Timer tmKanjiRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSpeed;
    }
}