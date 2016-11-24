namespace Tip.AppForms
{
    partial class fLanguages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLanguages));
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.lbChooseLanguages = new System.Windows.Forms.Label();
            this.bntOk = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguages
            // 
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Location = new System.Drawing.Point(147, 22);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(121, 21);
            this.cbLanguages.TabIndex = 0;
            this.cbLanguages.SelectedValueChanged += new System.EventHandler(this.cbLanguages_SelectedValueChanged);
            // 
            // lbChooseLanguages
            // 
            this.lbChooseLanguages.AutoSize = true;
            this.lbChooseLanguages.Location = new System.Drawing.Point(44, 26);
            this.lbChooseLanguages.Name = "lbChooseLanguages";
            this.lbChooseLanguages.Size = new System.Drawing.Size(97, 13);
            this.lbChooseLanguages.TabIndex = 1;
            this.lbChooseLanguages.Text = "Choose Language:";
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(193, 55);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(75, 23);
            this.bntOk.TabIndex = 2;
            this.bntOk.Text = "Ok";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 86);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(355, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMenu
            // 
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.Size = new System.Drawing.Size(0, 17);
            // 
            // fLanguages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 108);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.lbChooseLanguages);
            this.Controls.Add(this.cbLanguages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLanguages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Languages";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.Label lbChooseLanguages;
        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMenu;

    }
}