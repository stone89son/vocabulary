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

namespace Tip.AppForms
{
    public partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();
        }


   

        private void linkFace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkFace.Text);
        }

        private void linkDsSoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkDsSoft.Text);
            
        }

        private void lbDsSoft_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkDsSoft.Text);
            
        }

         
        private void LanguageInit(string langCode)
        {
            string langDocument = File.ReadAllText("Resources\\Languages\\" + langCode + ".json");
            JObject o = JObject.Parse(langDocument);
            JObject langfAbout = (JObject)o["App"]["fAbout"];

            #region Menu

            this.Text= (string)langfAbout["Title"];
            grbInfoSoft.Text = (string)langfAbout["grbInfoSoft"];
            gbDevApp.Text = (string)langfAbout["gbDevApp"];
            rtext.Text = (string)langfAbout["rtext"];

            #endregion

        }

        ProgramInit _init = new ProgramInit();
        private void fAbout_Load(object sender, EventArgs e)
        {
            LanguageInit(_init.GetLang());
        }


    }
}
