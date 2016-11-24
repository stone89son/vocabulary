using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Tip.Entities;
using Tip.Models;

namespace Tip.AppForms
{
    public partial class fTip : Form
    {


        DataStore _store = new DataStore();
        ProgramInit _init = new ProgramInit();
        Player player = new Player();

        List<DataStoreModel> _listDateStore = new List<DataStoreModel>();

        private int indexListSi = 0;
        private int countlistSi = 0;
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        JObject configAutoTip;
        private void LanguageInit(string langCode)
        {
            string langDocument = File.ReadAllText("Resources\\Languages\\" + langCode + ".json");
            JObject o = JObject.Parse(langDocument);
             configAutoTip = (JObject)o["App"]["fTip"];
       
            this.Text = (string)configAutoTip["Title"];

            formMainToolStripMenuItem.Text = (string)configAutoTip["formMainToolStripMenuItem"];
            optionToolStripMenuItem.Text = (string)configAutoTip["optionToolStripMenuItem"];
            exitToolStripMenuItem.Text = (string)configAutoTip["exitToolStripMenuItem"];
            stopToolStripMenuItem.Text = (string)configAutoTip["stopToolStripMenuItemStop"];
           
            stopToolStripMenuItem.Text = (string)configAutoTip["stopToolStripMenuItemStop"];
            lbLearnWord.Text = (string)configAutoTip["lbLearnWord"];
            lbMean.Text = (string)configAutoTip["lbMean"];
            lbPronounce.Text = (string)configAutoTip["lbPronounce"];
            lbEx.Text = (string)configAutoTip["lbEx"];

        }

        public fTip()
        {
            InitializeComponent();

            this.Left = resolution.Width - this.Width;
            int heightTabStart = 40;
            this.Top = resolution.Height - this.Height - heightTabStart;
            this.TopMost = true;

            GetAll();
            LanguageInit(_init.GetLang());
        }

        private void GetAll()
        {
            DateTime dateStart = _init.GetDateStart();
            DateTime dateEnd = _init.GetDateEnd();
            _listDateStore = _store.GetByDate(dateStart, dateEnd);
            if (_listDateStore != null)
            {
                countlistSi = _listDateStore.Count;


                timerAutoTip.Interval = _init.GetTimer();
                indexListSi = 0;
                if (countlistSi != 0)
                {
                    timerAutoTip.Stop();
                    timerAutoTip.Start();
                }
            }
        }
        private void fTip_Load(object sender, EventArgs e)
        {
         
        }

        private void timerAutoTip_Tick(object sender, EventArgs e)
        {
            if (_listDateStore != null && _listDateStore.Count>0)
            {
                if (indexListSi == -1) indexListSi = 0;
                lbStt.Text = (indexListSi + 1).ToString();
                lbLearnWord.Text = _listDateStore[indexListSi].Japanese;
                lbPronounce.Text = _listDateStore[indexListSi].Pronounce;
                if (!string.IsNullOrWhiteSpace(_listDateStore[indexListSi].Mean))
                {
                    lbMean.Text = _listDateStore[indexListSi].Mean.ToUpper();
                }
                else {
                    lbMean.Text = "";
                }
                lbEx.Text = _listDateStore[indexListSi].Example;

                if (!String.IsNullOrEmpty(_listDateStore[indexListSi].Picture))
                {
                    pbImage.ImageLocation = Config.pictureFolder + _listDateStore[indexListSi].Picture;
                }
                else
                {
                    pbImage.ImageLocation = Config.dataFolder + Config.picNoVarible;
                }
                indexListSi += 1;
                if (indexListSi == countlistSi)
                {
                    indexListSi = 0;
                }
            }
        }

        private void formMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm fign = new MainForm();
            fign.myFlagChange = new MainForm.GetFlagChang(GetValueOptionGetNumber);
            fign.myFlagChangeLanguage = new MainForm.GetFlagChangeLanguage(GetValueChangeLanguage);
            fign.myFlagChangeAutoConfig = new MainForm.GetFlagChangeAutoConfig(GetFlagChangeAutoConfig);
            fign.Show();
        }
        private void GetFlagChangeAutoConfig(bool val)
        {
            if (val == true)
            {
                timerAutoTip.Stop();
                GetAll();
                timerAutoTip.Start();
                stopToolStripMenuItem.Text = (string)configAutoTip["stopToolStripMenuItemStop"];
                btnStop.Text = (string)configAutoTip["stopToolStripMenuItemStop"];
                _stopRunTip = false;
            }
        }

        private void GetValueChangeLanguage(bool val)
        {
            if (val == true)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }
        }
        public void GetValueOptionGetNumber(bool valchange)
        {
            if (valchange == true)
            {
                GetAll();
            }
        }


        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fConfigAutoTip fign = new fConfigAutoTip();
            fign.myFlagChangeAutoConfig = new fConfigAutoTip.GetFlagChangeAutoConfig(GetFlagChangeAutoConfig);
            fign.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntHide_MouseHover(object sender, EventArgs e)
        {
            //this.Left = resolution.Width - this.Width;
            //this.Top = resolution.Height - this.Height-40;

            //this.Height = 10;
            //this.Width = 345;
            //this.Refresh();
        }

        bool flagShowHide;
        private int iHeight = 122;
        private int iWidth = 400;

        private void bntHide_Click(object sender, EventArgs e)
        {
            if (flagShowHide != true)
            {
                this.Height = 15;
                this.Width = 15;
                this.Refresh();
                this.Top = resolution.Height - this.Height - 40;
                this.Left = resolution.Width - this.Width;
                bntHide.FlatStyle = FlatStyle.Flat;
                bntHide.BackColor = Color.FromArgb(202, 81, 0);
                bntHide.UseVisualStyleBackColor = false;
                flagShowHide = true;
            }
            else
            {
                this.Height = iHeight;
                this.Width = iWidth;
                this.Refresh();
                this.Left = resolution.Width - this.Width;
                this.Top = resolution.Height - this.Height - 40;
                bntHide.FlatStyle = FlatStyle.Flat;
                Color color = Color.FromArgb(124, 187, 0);
                bntHide.BackColor = color;
                bntHide.UseVisualStyleBackColor = false;
                flagShowHide = false; ;
            }
        }

        bool _stopRunTip;
        private void StopRun() {
            if (_stopRunTip != true)
            {
                timerAutoTip.Stop();
                timerAutoTip.Dispose();
                stopToolStripMenuItem.Text = (string)configAutoTip["stopToolStripMenuItemStart"];
            }
            else
            {
                timerAutoTip.Start();
                stopToolStripMenuItem.Text = (string)configAutoTip["stopToolStripMenuItemStop"];
            }
            btnStop.Text = stopToolStripMenuItem.Text;
            _stopRunTip = !_stopRunTip;
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopRun();
        }
         bool _stopShowMeanTip;
        private void btnHideMean_Click(object sender, EventArgs e)
        {
            if (_stopShowMeanTip != true)
            {
                lbMean.Visible = false;
                lbEx.Visible = false;
                lbPronounce.Visible = false;
                pbImage.Visible = false;
                btnHideMean.Text = "hiện";
            }
            else
            {
                lbMean.Visible = true;
                lbEx.Visible = true;
                lbPronounce.Visible = true;
                pbImage.Visible = true;
                btnHideMean.Text = "ẩn";
            }
            _stopShowMeanTip = !_stopShowMeanTip;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopRun();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (indexListSi>0) {
                --indexListSi;
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if (indexListSi<_listDateStore.Count)
            {
                ++indexListSi;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            indexListSi = -1;
        }
    }
}
