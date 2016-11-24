using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Tip.Entities;

namespace Tip.AppForms
{
    public partial class fConfigAutoTip : Form
    {
        ProgramInit init = new ProgramInit();



        public fConfigAutoTip()
        {
            InitializeComponent();
        
            CultureInfo ci = new CultureInfo("vi-VN");

            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

            dpEnd.CustomFormat = "dd/MM/yyy";

           dpStart.Value = init.GetDateStart();
           dpEnd.Value = init.GetDateEnd();

           txtTimeChangeWord.Text= init.GetTimer().ToString();
        }

        public delegate void GetFlagChangeAutoConfig(bool flag);

        public GetFlagChangeAutoConfig myFlagChangeAutoConfig;

        private void bntOk_Click(object sender, EventArgs e)
        {
            try
            {
                init.SetDateStart(dpStart.Value);
                init.SetDateEnd(dpEnd.Value);
                init.SetTimer(Convert.ToInt16(txtTimeChangeWord.Text));

                statusMenu.Text = (string)configStatus["EditSuccess"];

                myFlagChangeAutoConfig(true);
            }
            catch {
                statusMenu.Text = (string)configStatus["EditFaile"];
            
            }

        }

        private void fConfigAutoTip_Load(object sender, EventArgs e)
        {
            LanguageInit(init.GetLang());

        }

        JObject configStatus;
        private void LanguageInit(string langCode)
        {
            string langDocument = File.ReadAllText("Resources\\Languages\\" + langCode + ".json");
            JObject o = JObject.Parse(langDocument);
            JObject configAutoTip = (JObject)o["App"]["fConfigAutoTip"];
            configStatus = (JObject)o["App"]["Status"];

          
            this.Text = (string)configAutoTip["Title"];

            lbDateEnd.Text = (string)configAutoTip["lbDateEnd"];
            lbDateStart.Text = (string)configAutoTip["lbDateStart"];

            bntOk.Text = (string)configAutoTip["bntOk"];
            lbTimeChangeWord.Text = (string)configAutoTip["lbTimeChangeWord"];
        }
    }
}
