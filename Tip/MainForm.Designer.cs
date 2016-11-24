namespace Tip
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bntEdit = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSpeak = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbPronounce = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.txtPronounce = new System.Windows.Forms.TextBox();
            this.TimerMainCheck = new System.Windows.Forms.Timer(this.components);
            this.TimerGetNumber = new System.Windows.Forms.Timer(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusPro = new System.Windows.Forms.ToolStripProgressBar();
            this.mainStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bntAdd = new System.Windows.Forms.Button();
            this.lbLanguageLearn = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFindByDay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnAddFast = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtChooseImage = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.bntChooseImage = new System.Windows.Forms.Button();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemember = new System.Windows.Forms.TextBox();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.bntFind = new System.Windows.Forms.Button();
            this.bntDelAll = new System.Windows.Forms.Button();
            this.bntDel = new System.Windows.Forms.Button();
            this.txtJapanese = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchKanjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langugesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoLearnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configLearnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbExample = new System.Windows.Forms.Label();
            this.lvResult = new System.Windows.Forms.ListView();
            this.clIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clJapanese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPronounce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMean = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clExample = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSpeak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUrlImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNumerLession = new System.Windows.Forms.TextBox();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntEdit
            // 
            this.bntEdit.Location = new System.Drawing.Point(82, 120);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(60, 27);
            this.bntEdit.TabIndex = 12;
            this.bntEdit.Text = "Lưu";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(421, 58);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(32, 13);
            this.lbDate.TabIndex = 29;
            this.lbDate.Text = "Ngày";
            // 
            // lbSpeak
            // 
            this.lbSpeak.AutoSize = true;
            this.lbSpeak.Location = new System.Drawing.Point(417, 30);
            this.lbSpeak.Name = "lbSpeak";
            this.lbSpeak.Size = new System.Drawing.Size(53, 13);
            this.lbSpeak.TabIndex = 27;
            this.lbSpeak.Text = "Cách nhớ";
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Location = new System.Drawing.Point(24, 75);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(48, 13);
            this.lbMean.TabIndex = 20;
            this.lbMean.Text = "Hán-Việt";
            // 
            // lbPronounce
            // 
            this.lbPronounce.AutoSize = true;
            this.lbPronounce.Location = new System.Drawing.Point(220, 33);
            this.lbPronounce.Name = "lbPronounce";
            this.lbPronounce.Size = new System.Drawing.Size(73, 13);
            this.lbPronounce.TabIndex = 24;
            this.lbPronounce.Text = "Cách phát âm";
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(82, 71);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(130, 20);
            this.txtMean.TabIndex = 2;
            // 
            // txtPronounce
            // 
            this.txtPronounce.Location = new System.Drawing.Point(283, 29);
            this.txtPronounce.Name = "txtPronounce";
            this.txtPronounce.Size = new System.Drawing.Size(130, 20);
            this.txtPronounce.TabIndex = 6;
            // 
            // TimerMainCheck
            // 
            this.TimerMainCheck.Interval = 5000;
            // 
            // TimerGetNumber
            // 
            this.TimerGetNumber.Interval = 200;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPro,
            this.mainStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 639);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1008, 22);
            this.statusStripMain.TabIndex = 31;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // statusPro
            // 
            this.statusPro.Name = "statusPro";
            this.statusPro.Size = new System.Drawing.Size(500, 16);
            // 
            // mainStatus
            // 
            this.mainStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(39, 17);
            this.mainStatus.Text = "Status";
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(16, 120);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(60, 27);
            this.bntAdd.TabIndex = 11;
            this.bntAdd.Text = "Thêm";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // lbLanguageLearn
            // 
            this.lbLanguageLearn.AutoSize = true;
            this.lbLanguageLearn.Location = new System.Drawing.Point(8, 33);
            this.lbLanguageLearn.Name = "lbLanguageLearn";
            this.lbLanguageLearn.Size = new System.Drawing.Size(39, 13);
            this.lbLanguageLearn.TabIndex = 1;
            this.lbLanguageLearn.Text = "Từ mới";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddLesson);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumerLession);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindByDay);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtEnd);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFast);
            this.splitContainer1.Panel1.Controls.Add(this.txtStart);
            this.splitContainer1.Panel1.Controls.Add(this.btnTranslate);
            this.splitContainer1.Panel1.Controls.Add(this.txtChooseImage);
            this.splitContainer1.Panel1.Controls.Add(this.picImage);
            this.splitContainer1.Panel1.Controls.Add(this.bntChooseImage);
            this.splitContainer1.Panel1.Controls.Add(this.dateDate);
            this.splitContainer1.Panel1.Controls.Add(this.bntEdit);
            this.splitContainer1.Panel1.Controls.Add(this.txtRemember);
            this.splitContainer1.Panel1.Controls.Add(this.txtExample);
            this.splitContainer1.Panel1.Controls.Add(this.txtMean);
            this.splitContainer1.Panel1.Controls.Add(this.txtPronounce);
            this.splitContainer1.Panel1.Controls.Add(this.bntAdd);
            this.splitContainer1.Panel1.Controls.Add(this.bntFind);
            this.splitContainer1.Panel1.Controls.Add(this.bntDelAll);
            this.splitContainer1.Panel1.Controls.Add(this.bntDel);
            this.splitContainer1.Panel1.Controls.Add(this.txtJapanese);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.lbDate);
            this.splitContainer1.Panel1.Controls.Add(this.lbSpeak);
            this.splitContainer1.Panel1.Controls.Add(this.lbExample);
            this.splitContainer1.Panel1.Controls.Add(this.lbMean);
            this.splitContainer1.Panel1.Controls.Add(this.lbPronounce);
            this.splitContainer1.Panel1.Controls.Add(this.lbLanguageLearn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvResult);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 661);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 30;
            // 
            // btnFindByDay
            // 
            this.btnFindByDay.Location = new System.Drawing.Point(211, 120);
            this.btnFindByDay.Name = "btnFindByDay";
            this.btnFindByDay.Size = new System.Drawing.Size(97, 27);
            this.btnFindByDay.TabIndex = 48;
            this.btnFindByDay.Text = "Tìm bởi ngày học";
            this.btnFindByDay.UseVisualStyleBackColor = true;
            this.btnFindByDay.Click += new System.EventHandler(this.btnFindByDay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Vị trí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Số lượng";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(624, 124);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(39, 20);
            this.txtEnd.TabIndex = 45;
            this.txtEnd.Text = "50";
            // 
            // btnAddFast
            // 
            this.btnAddFast.Location = new System.Drawing.Point(672, 120);
            this.btnAddFast.Name = "btnAddFast";
            this.btnAddFast.Size = new System.Drawing.Size(90, 27);
            this.btnAddFast.TabIndex = 44;
            this.btnAddFast.Text = "Thêm nhanh";
            this.btnAddFast.UseVisualStyleBackColor = true;
            this.btnAddFast.Click += new System.EventHandler(this.btnAddFast_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(518, 124);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(39, 20);
            this.txtStart.TabIndex = 42;
            this.txtStart.Text = "1";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(137, 90);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 41;
            this.btnTranslate.Text = "Dịch";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtChooseImage
            // 
            this.txtChooseImage.Location = new System.Drawing.Point(912, 30);
            this.txtChooseImage.Name = "txtChooseImage";
            this.txtChooseImage.Size = new System.Drawing.Size(84, 20);
            this.txtChooseImage.TabIndex = 9;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(766, 29);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(140, 120);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 37;
            this.picImage.TabStop = false;
            // 
            // bntChooseImage
            // 
            this.bntChooseImage.Location = new System.Drawing.Point(912, 56);
            this.bntChooseImage.Name = "bntChooseImage";
            this.bntChooseImage.Size = new System.Drawing.Size(86, 23);
            this.bntChooseImage.TabIndex = 10;
            this.bntChooseImage.Text = "Chọn ảnh";
            this.bntChooseImage.UseVisualStyleBackColor = true;
            this.bntChooseImage.Click += new System.EventHandler(this.bntChooseImage_Click);
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(465, 54);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(144, 20);
            this.dateDate.TabIndex = 8;
            // 
            // txtRemember
            // 
            this.txtRemember.Location = new System.Drawing.Point(474, 27);
            this.txtRemember.Name = "txtRemember";
            this.txtRemember.Size = new System.Drawing.Size(265, 20);
            this.txtRemember.TabIndex = 3;
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(283, 56);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(130, 20);
            this.txtExample.TabIndex = 7;
            // 
            // bntFind
            // 
            this.bntFind.Location = new System.Drawing.Point(150, 120);
            this.bntFind.Name = "bntFind";
            this.bntFind.Size = new System.Drawing.Size(60, 27);
            this.bntFind.TabIndex = 14;
            this.bntFind.Text = "Tìm";
            this.bntFind.UseVisualStyleBackColor = true;
            this.bntFind.Click += new System.EventHandler(this.bntFind_Click);
            // 
            // bntDelAll
            // 
            this.bntDelAll.Location = new System.Drawing.Point(382, 120);
            this.bntDelAll.Name = "bntDelAll";
            this.bntDelAll.Size = new System.Drawing.Size(88, 27);
            this.bntDelAll.TabIndex = 16;
            this.bntDelAll.Text = "Xóa cả";
            this.bntDelAll.UseVisualStyleBackColor = true;
            this.bntDelAll.Click += new System.EventHandler(this.bntDelAll_Click);
            // 
            // bntDel
            // 
            this.bntDel.Location = new System.Drawing.Point(315, 120);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(60, 27);
            this.bntDel.TabIndex = 15;
            this.bntDel.Text = "Xóa";
            this.bntDel.UseVisualStyleBackColor = true;
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // txtJapanese
            // 
            this.txtJapanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJapanese.Location = new System.Drawing.Point(82, 28);
            this.txtJapanese.Name = "txtJapanese";
            this.txtJapanese.Size = new System.Drawing.Size(130, 38);
            this.txtJapanese.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchKanjiToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchKanjiToolStripMenuItem
            // 
            this.danhSáchKanjiToolStripMenuItem.Name = "danhSáchKanjiToolStripMenuItem";
            this.danhSáchKanjiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.danhSáchKanjiToolStripMenuItem.Text = "Danh sách Kanji";
            this.danhSáchKanjiToolStripMenuItem.Click += new System.EventHandler(this.danhSáchKanjiToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langugesToolStripMenuItem,
            this.autoLearnToolStripMenuItem,
            this.configLearnToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // langugesToolStripMenuItem
            // 
            this.langugesToolStripMenuItem.Name = "langugesToolStripMenuItem";
            this.langugesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.langugesToolStripMenuItem.Text = "Language";
            this.langugesToolStripMenuItem.Click += new System.EventHandler(this.langugesToolStripMenuItem_Click);
            // 
            // autoLearnToolStripMenuItem
            // 
            this.autoLearnToolStripMenuItem.Name = "autoLearnToolStripMenuItem";
            this.autoLearnToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.autoLearnToolStripMenuItem.Text = "Auto Learn";
            this.autoLearnToolStripMenuItem.Click += new System.EventHandler(this.autoLearnToolStripMenuItem_Click);
            // 
            // configLearnToolStripMenuItem
            // 
            this.configLearnToolStripMenuItem.Name = "configLearnToolStripMenuItem";
            this.configLearnToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.configLearnToolStripMenuItem.Text = "Config Learn";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbExample
            // 
            this.lbExample.AutoSize = true;
            this.lbExample.Location = new System.Drawing.Point(232, 59);
            this.lbExample.Name = "lbExample";
            this.lbExample.Size = new System.Drawing.Size(38, 13);
            this.lbExample.TabIndex = 25;
            this.lbExample.Text = "Nghĩa";
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIndex,
            this.clId,
            this.clJapanese,
            this.clPronounce,
            this.clMean,
            this.clGenre,
            this.clExample,
            this.clSpeak,
            this.clUrlImage,
            this.clDate});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.LabelEdit = true;
            this.lvResult.Location = new System.Drawing.Point(0, 4);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1008, 473);
            this.lvResult.TabIndex = 19;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.SelectedIndexChanged += new System.EventHandler(this.lvResult_SelectedIndexChanged);
            // 
            // clIndex
            // 
            this.clIndex.Text = "STT";
            this.clIndex.Width = 40;
            // 
            // clId
            // 
            this.clId.Width = 0;
            // 
            // clJapanese
            // 
            this.clJapanese.Text = "Từ mới";
            this.clJapanese.Width = 64;
            // 
            // clPronounce
            // 
            this.clPronounce.Text = "Cách phát âm";
            this.clPronounce.Width = 84;
            // 
            // clMean
            // 
            this.clMean.Text = "Nghĩa";
            this.clMean.Width = 86;
            // 
            // clGenre
            // 
            this.clGenre.Text = "Loại";
            this.clGenre.Width = 222;
            // 
            // clExample
            // 
            this.clExample.Text = "Ví dụ";
            this.clExample.Width = 80;
            // 
            // clSpeak
            // 
            this.clSpeak.Text = "Đọc";
            this.clSpeak.Width = 76;
            // 
            // clUrlImage
            // 
            this.clUrlImage.Text = "Đường dẫn ảnh";
            this.clUrlImage.Width = 100;
            // 
            // clDate
            // 
            this.clDate.Text = "Ngày";
            this.clDate.Width = 100;
            // 
            // txtNumerLession
            // 
            this.txtNumerLession.Location = new System.Drawing.Point(474, 98);
            this.txtNumerLession.Name = "txtNumerLession";
            this.txtNumerLession.Size = new System.Drawing.Size(100, 20);
            this.txtNumerLession.TabIndex = 49;
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(580, 94);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(60, 27);
            this.btnAddLesson.TabIndex = 50;
            this.btnAddLesson.Text = "Thêm";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý từ mới Ver 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntEdit;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSpeak;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbPronounce;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.TextBox txtPronounce;
        private System.Windows.Forms.Timer TimerMainCheck;
        private System.Windows.Forms.Timer TimerGetNumber;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripProgressBar statusPro;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label lbLanguageLearn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bntFind;
        private System.Windows.Forms.Button bntDelAll;
        private System.Windows.Forms.Button bntDel;
        private System.Windows.Forms.TextBox txtJapanese;
        private System.Windows.Forms.ToolStripStatusLabel mainStatus;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Button bntChooseImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langugesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.Label lbExample;
        private System.Windows.Forms.TextBox txtChooseImage;
        private System.Windows.Forms.ToolStripMenuItem autoLearnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configLearnToolStripMenuItem;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader clIndex;
        private System.Windows.Forms.ColumnHeader clId;
        private System.Windows.Forms.ColumnHeader clJapanese;
        private System.Windows.Forms.ColumnHeader clPronounce;
        private System.Windows.Forms.ColumnHeader clMean;
        private System.Windows.Forms.ColumnHeader clGenre;
        private System.Windows.Forms.ColumnHeader clExample;
        private System.Windows.Forms.ColumnHeader clSpeak;
        private System.Windows.Forms.ColumnHeader clUrlImage;
        private System.Windows.Forms.ColumnHeader clDate;
        private System.Windows.Forms.TextBox txtRemember;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.ToolStripMenuItem danhSáchKanjiToolStripMenuItem;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnAddFast;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindByDay;
        private System.Windows.Forms.TextBox txtNumerLession;
        private System.Windows.Forms.Button btnAddLesson;
    }
}

