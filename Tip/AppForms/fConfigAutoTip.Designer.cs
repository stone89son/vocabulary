namespace Tip.AppForms
{
    partial class fConfigAutoTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConfigAutoTip));
            this.lbDateStart = new System.Windows.Forms.Label();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.lbDateEnd = new System.Windows.Forms.Label();
            this.bntOk = new System.Windows.Forms.Button();
            this.lbTimeChangeWord = new System.Windows.Forms.Label();
            this.txtTimeChangeWord = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDateStart
            // 
            this.lbDateStart.AutoSize = true;
            this.lbDateStart.Location = new System.Drawing.Point(59, 22);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(55, 13);
            this.lbDateStart.TabIndex = 22;
            this.lbDateStart.Text = "Date Start";
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(159, 46);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(200, 20);
            this.dpEnd.TabIndex = 26;
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(159, 19);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(200, 20);
            this.dpStart.TabIndex = 27;
            // 
            // lbDateEnd
            // 
            this.lbDateEnd.AutoSize = true;
            this.lbDateEnd.Location = new System.Drawing.Point(62, 48);
            this.lbDateEnd.Name = "lbDateEnd";
            this.lbDateEnd.Size = new System.Drawing.Size(52, 13);
            this.lbDateEnd.TabIndex = 28;
            this.lbDateEnd.Text = "Date End";
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(282, 105);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(75, 23);
            this.bntOk.TabIndex = 29;
            this.bntOk.Text = "Ok";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // lbTimeChangeWord
            // 
            this.lbTimeChangeWord.AutoSize = true;
            this.lbTimeChangeWord.Location = new System.Drawing.Point(15, 79);
            this.lbTimeChangeWord.Name = "lbTimeChangeWord";
            this.lbTimeChangeWord.Size = new System.Drawing.Size(99, 13);
            this.lbTimeChangeWord.TabIndex = 30;
            this.lbTimeChangeWord.Text = "Time Change Word";
            // 
            // txtTimeChangeWord
            // 
            this.txtTimeChangeWord.Location = new System.Drawing.Point(159, 76);
            this.txtTimeChangeWord.Name = "txtTimeChangeWord";
            this.txtTimeChangeWord.Size = new System.Drawing.Size(198, 20);
            this.txtTimeChangeWord.TabIndex = 31;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 147);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(397, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMenu
            // 
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.Size = new System.Drawing.Size(0, 17);
            // 
            // fConfigAutoTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 169);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtTimeChangeWord);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.lbTimeChangeWord);
            this.Controls.Add(this.lbDateEnd);
            this.Controls.Add(this.lbDateStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fConfigAutoTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config Auto";
            this.Load += new System.EventHandler(this.fConfigAutoTip_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateStart;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label lbDateEnd;
        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.Label lbTimeChangeWord;
        private System.Windows.Forms.TextBox txtTimeChangeWord;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMenu;
    }
}