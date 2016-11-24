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
    public partial class fLanguages : Form
    {
        ProgramInit _init = new ProgramInit();

        public fLanguages()
        {
            InitializeComponent();
            Get();
            cbLanguages.SelectedValue= _init.GetLang();

            LanguageInit(_init.GetLang());

        }
        

        JObject configStatus;
        private void LanguageInit(string langCode)
        {
            string langDocument = File.ReadAllText("Resources\\Languages\\" + langCode + ".json");
            JObject o = JObject.Parse(langDocument);
            JObject configAutoTip = (JObject)o["App"]["fLanguages"];
            configStatus = (JObject)o["App"]["Status"];


            this.Text = (string)configAutoTip["Title"];

            lbChooseLanguages.Text = (string)configAutoTip["lbChooseLanguages"];
            bntOk.Text = (string)configAutoTip["bntOk"];
        
        }




        List<LanguageModel> listLang = new List<LanguageModel>();
        public void Get() {
            LanguageModel langModelvi = new LanguageModel();
            langModelvi.Id = "vi";
            langModelvi.Name = "Tiếng việt";

            LanguageModel langModelen = new LanguageModel();
            langModelen.Id = "en";
            langModelen.Name = "English";

            LanguageModel langModelja= new LanguageModel();
            langModelja.Id = "ja";
            langModelja.Name = "Japanese";

            listLang.Add(langModelvi);
            listLang.Add(langModelen);
            listLang.Add(langModelja);

            cbLanguages.DataSource = listLang;
            cbLanguages.DisplayMember = "Name";
            cbLanguages.ValueMember = "Id";
        }

        private void cbLanguages_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        public delegate void GetFlagChang(bool flag);

        public GetFlagChang myFlagChange;
        private void bntOk_Click(object sender, EventArgs e)
        {

          
            _init.SetLang(cbLanguages.SelectedValue.ToString());

            statusMenu.Text = (string)configStatus["EditSuccess"];
            MessageBox.Show("Application Restart Now!");
            myFlagChange(true);
        }


    }
}
