namespace Tip
{
    partial class fTipTemp
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
            this.lbEx = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbPronounce = new System.Windows.Forms.Label();
            this.lbLearnWord = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.timerAutoTip = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEx
            // 
            this.lbEx.AutoSize = true;
            this.lbEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbEx.Location = new System.Drawing.Point(372, 222);
            this.lbEx.Name = "lbEx";
            this.lbEx.Size = new System.Drawing.Size(56, 15);
            this.lbEx.TabIndex = 30;
            this.lbEx.Text = "Example";
            this.lbEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMean.ForeColor = System.Drawing.Color.Purple;
            this.lbMean.Location = new System.Drawing.Point(371, 196);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(49, 20);
            this.lbMean.TabIndex = 29;
            this.lbMean.Text = "Mean";
            // 
            // lbPronounce
            // 
            this.lbPronounce.AutoSize = true;
            this.lbPronounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPronounce.ForeColor = System.Drawing.Color.Maroon;
            this.lbPronounce.Location = new System.Drawing.Point(281, 219);
            this.lbPronounce.Name = "lbPronounce";
            this.lbPronounce.Size = new System.Drawing.Size(86, 20);
            this.lbPronounce.TabIndex = 28;
            this.lbPronounce.Text = "Pronounce";
            // 
            // lbLearnWord
            // 
            this.lbLearnWord.AutoSize = true;
            this.lbLearnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLearnWord.ForeColor = System.Drawing.Color.Green;
            this.lbLearnWord.Location = new System.Drawing.Point(274, 192);
            this.lbLearnWord.Name = "lbLearnWord";
            this.lbLearnWord.Size = new System.Drawing.Size(134, 29);
            this.lbLearnWord.TabIndex = 27;
            this.lbLearnWord.Text = "Learn word";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(551, 191);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(68, 58);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 26;
            this.pbImage.TabStop = false;
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
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.optionToolStripMenuItem.Text = "Option Auto Learn";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShowShortcutKeys = false;
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // bntHide
            // 
            this.bntHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.bntHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHide.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHide.ForeColor = System.Drawing.Color.White;
            this.bntHide.Location = new System.Drawing.Point(275, 178);
            this.bntHide.Name = "bntHide";
            this.bntHide.Size = new System.Drawing.Size(345, 15);
            this.bntHide.TabIndex = 31;
            this.bntHide.UseVisualStyleBackColor = false;
            // 
            // fTipTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 426);
            this.Controls.Add(this.lbEx);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.lbPronounce);
            this.Controls.Add(this.lbLearnWord);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.bntHide);
            this.Name = "fTipTemp";
            this.Text = "fTipTemp";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEx;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbPronounce;
        private System.Windows.Forms.Label lbLearnWord;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer timerAutoTip;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem formMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button bntHide;

    }
}