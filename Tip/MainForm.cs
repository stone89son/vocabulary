using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using GoogleTranslateWithNoApiHelper;
using Newtonsoft.Json.Linq;
using Tip.AppForms;
using Tip.Entities;
using Tip.Models;
using ExcelLibrary.SpreadSheet;
using Newtonsoft.Json;

namespace Tip
{
    public partial class MainForm : Form
    {
        ProgramInit _init = new ProgramInit();
       
        public MainForm()
        {
            InitializeComponent();
            GetAll();
            GetDic();
            LanguageInit(_init.GetLang());
        }

        DataStore _dataStoreEntity = new DataStore();

        private string imgTempUrl = "";
        string mediaTempUrl = "";
        string safeMediaFileName ;
        Player player = new Player();


        JObject statusObj;
        JObject mainForm;


        public delegate void GetFlagChang(bool flag);

        public GetFlagChang myFlagChange;
        private string statusnotFound;
        private void LanguageInit(string langCode)
        {
            string langDocument = File.ReadAllText("Resources\\Languages\\" + langCode + ".json");
            JObject o = JObject.Parse(langDocument);

            mainForm = (JObject)o["App"]["MainForm"];
            statusObj = (JObject)o["App"]["Status"];

            #region Menu
          
            optionToolStripMenuItem.Text = (string)mainForm["Option"];

            langugesToolStripMenuItem.Text = (string)mainForm["langugesToolStripMenuItem"];
            autoLearnToolStripMenuItem.Text = (string)mainForm["autoLearnToolStripMenuItem"];

            aboutToolStripMenuItem.Text = (string)mainForm["aboutToolStripMenuItem"];

            lbLanguageLearn.Text = (string)mainForm["lbLanguageLearn"];
            lbMean.Text = (string)mainForm["lbMean"];
            lbSpeak.Text = (string)mainForm["lbSpeak"];
            bntChooseImage.Text = (string)mainForm["bntChooseImage"];

            lbPronounce.Text = (string)mainForm["lbPronounce"];
            lbExample.Text = (string)mainForm["lbExample"];
            lbDate.Text = (string)mainForm["lbDate"];

            bntAdd.Text = (string)mainForm["bntAdd"];
            bntEdit.Text = (string)mainForm["bntEdit"];
            bntFind.Text = (string)mainForm["bntFind"];
            bntDel.Text = (string)mainForm["bntDel"];
            bntDelAll.Text = (string)mainForm["bntDelAll"];
            statusnotFound = (string)mainForm["statusnotFound"];
            

            lvResult.Columns[0].Text = (string)mainForm["clIndex"];
            lvResult.Columns[2].Text = lbLanguageLearn.Text;
            lvResult.Columns[3].Text = lbPronounce.Text;
            lvResult.Columns[4].Text = lbMean.Text;
            lvResult.Columns[5].Text = "Ghi nhớ";
            lvResult.Columns[6].Text = lbExample.Text;
            lvResult.Columns[7].Text = lbSpeak.Text;

            lvResult.Columns[8].Text = (string)mainForm["clUrlImage"];
            lvResult.Columns[9].Text = (string)mainForm["clDate"];

            lbDate.Text = (string)mainForm["lbDate"];

            #endregion

        }

        #region Result

        private DataStoreModel tempDataStoreModel=new DataStoreModel();

        private void _showListView(List<DataStoreModel> listSoModel)
        {
         
            lvResult.Items.Clear();
            int countList = 1;
            foreach (var item in listSoModel)
            {
              
               
                string[] arr = new string[12];

                ListViewItem itm = new ListViewItem();

                arr[0] = countList.ToString();
                arr[1] = item.Id;
                arr[2] = item.Japanese;
                arr[3] = item.Pronounce;
                arr[4] = item.Mean;
                arr[5] = item.Genre;
                arr[6] = item.Example;
                arr[7] = item.Speak;
                arr[8] = item.Picture;
                arr[9] = item.Date;

                itm = new ListViewItem(arr);
                lvResult.Items.Add(itm);

                countList++;
            }
        }

        private void GetAll()
        {
            try
            {
                List<DataStoreModel> lis = _dataStoreEntity.GetAll();
                _showListView(lis);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Lỗi" + ex.ToString());
            }
        }

        private void Add()
        {
            try
            {
                if (txtJapanese.Text != "")
                {
                    DataStoreModel _reModel = new DataStoreModel();

                    _reModel.Id = Unitils.RandomGUID();
                    _reModel.Japanese = txtJapanese.Text.Trim();
                    _reModel.Pronounce = txtPronounce.Text;
                    _reModel.Mean = txtMean.Text;
                    _reModel.Example = txtExample.Text;
                    _reModel.Genre = txtRemember.Text;
                    _reModel.Date = dateDate.Value.ToString("dd/MM/yyyy");

                    try
                    {
                        if (!String.IsNullOrEmpty(txtChooseImage.Text))
                        {
                            if (!File.Exists(picImage.ImageLocation))
                            {
                                System.IO.File.Copy(picImage.ImageLocation, Config.pictureFolder + imgTempUrl, true);
                            }
                            _reModel.Picture = imgTempUrl;
                        }
                        else {
                            _reModel.Picture = "";
                        }
                    }
                    catch(Exception ex) {
                        string abc = ex.ToString();
                    }

                    _dataStoreEntity.Add(_reModel);
                    GetAll();

                    myFlagChange(true);

                    mainStatus.Text = (string)statusObj["AddSuccess"];
                    
                    
                }
                else
                {
                    mainStatus.Text = (string)statusObj["AddFaile"];
                   
                }

            }
            catch 
            {

                mainStatus.Text = (string)statusObj["AddFaile"];
            }
        }

        private void Find()
        {
            try
            {

                lvResult.Items.Clear();
                List<DataStoreModel> listSoModel = _dataStoreEntity.FindAll(txtJapanese.Text);

                _showListView(listSoModel);
                myFlagChange(true);
                mainStatus.Text = (string)statusObj["FindSuccess"];
            }
            catch
            {
                mainStatus.Text = (string)statusObj["FindFaile"];
            }

        }

        private void FindAll()
        {
            try
            {
                lvResult.Items.Clear();
                List<DataStoreModel> _reModel = _dataStoreEntity.FindAll(txtJapanese.Text);
                _showListView(_reModel);
                mainStatus.Text = (string)statusObj["FindSuccess"];
            }
            catch
            {
                mainStatus.Text = (string)statusObj["FindFaile"];
            }

        }

        private void Edit()
        {
            try
            {

                DataStoreModel _reModel = new DataStoreModel();
                _reModel.Id = tempDataStoreModel.Id;
                _reModel.Japanese = txtJapanese.Text.Trim();
                _reModel.Pronounce = txtPronounce.Text;
                _reModel.Mean = txtMean.Text;
                _reModel.Example = txtExample.Text;
                _reModel.Genre = txtRemember.Text;
                _reModel.Date = dateDate.Value.ToString("dd/MM/yyyy");

                _dataStoreEntity.Update(tempDataStoreModel.Id, _reModel);
                try
                {
                    if (!String.IsNullOrEmpty(txtChooseImage.Text))
                    {
                        if (!File.Exists(picImage.ImageLocation))
                        {
                            System.IO.File.Copy(picImage.ImageLocation, Config.pictureFolder + imgTempUrl, true);
                        }
                        _reModel.Picture = imgTempUrl;
                    }
                    else
                    {
                        _reModel.Picture = "";
                    }
                }
                catch (Exception ex)
                {
                    string abc = ex.ToString();
                }
                _dataStoreEntity.Update(tempDataStoreModel.Id, _reModel);
                GetAll();
                myFlagChange(true);
                mainStatus.Text = (string)statusObj["EditSuccess"];
            }
            catch 
            {

                mainStatus.Text = (string)statusObj["EditFaile"];
            }


        }

        private void Del()
        {
            try
            {

                _dataStoreEntity.Delete(tempDataStoreModel.Id);
                //if (File.Exists(Config.pictureFolder + imgTempUrl)) {
                //    File.Delete(Config.pictureFolder + imgTempUrl);
                //}
                myFlagChange(true);
                GetAll();

                mainStatus.Text = (string)statusObj["DelSuccess"];
            }
            catch (Exception )
            {

                mainStatus.Text = (string)statusObj["DelFaile"];
            }


        }

        private void DelAll()
        {
            if (DialogResult.Yes == MessageBox.Show((string)statusObj["WarningDelAll"], (string)statusObj["WarningDelAllTitle"], MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    Unitils.ResetAll(Config.dataStoreFile);
                   // Unitils.DeleteAll(Config.pictureFolder);
                    //Unitils.DeleteAll(Config.soundFolder);
                    GetAll();
                    myFlagChange(true);

                    mainStatus.Text = (string)statusObj["DelAllSuccess"];
                   
                }
                catch
                {
                    mainStatus.Text = (string)statusObj["DelAllFaile"];
                }

            }
            else
            {
                mainStatus.Text = (string)statusObj["CancelDelAll"];
        
            }

        }

        #endregion
      

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void bntEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void bntFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
           Del();
        }

        private void bntDelAll_Click(object sender, EventArgs e)
        {
            DelAll();
        }

        private void lvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itemCollectionSong =
           this.lvResult.SelectedItems;

            foreach (ListViewItem item in itemCollectionSong)
            {
                tempDataStoreModel.Id= item.SubItems[1].Text;
                txtJapanese.Text = item.SubItems[2].Text;
                txtPronounce.Text = item.SubItems[3].Text;
                txtMean.Text = item.SubItems[4].Text;
                txtRemember.Text = item.SubItems[5].Text;
                txtExample.Text = item.SubItems[6].Text;
            
                dateDate.Value = DateTime.ParseExact(item.SubItems[9].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!String.IsNullOrEmpty(item.SubItems[8].Text))
                {
                    imgTempUrl = item.SubItems[8].Text;
                    txtChooseImage.Text = Config.pictureFolder + imgTempUrl;
                    picImage.ImageLocation = Config.pictureFolder + imgTempUrl;

                }
                else {
                    imgTempUrl = "";
                    txtChooseImage.Text ="";
                    picImage.ImageLocation = Config.dataFolder + Config.picNoVarible;
                }
                if (!String.IsNullOrEmpty(item.SubItems[7].Text))
                {
                    mediaTempUrl = item.SubItems[7].Text;
                }
                else {
                    mediaTempUrl = "";
                }
            }
        }
       
        private void bntChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDiagLogImage = new OpenFileDialog();
            openDiagLogImage.Filter = (string)mainForm["ChooseImageText"] + "|*.BMP;*.GIF;*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";
            DialogResult dr = openDiagLogImage.ShowDialog(); 

            if (dr == DialogResult.OK) {

                picImage.ImageLocation = openDiagLogImage.FileName;

                imgTempUrl = openDiagLogImage.SafeFileName;
                txtChooseImage.Text = openDiagLogImage.FileName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }
        private void bntChooseSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog openMedia = new OpenFileDialog();
            openMedia.Filter = (string)mainForm["ChooseSoundText"] + "|*.mp3;*.wav|All files (*.*)|*.*";
            DialogResult dr = openMedia.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtRemember.Text = openMedia.FileName;
                safeMediaFileName = openMedia.SafeFileName;
                player.play(txtRemember.Text);
            }
        }

        public delegate void GetFlagChangeAutoConfig(bool flag);

        public GetFlagChangeAutoConfig myFlagChangeAutoConfig;

        private void autoLearnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fConfigAutoTip fign = new fConfigAutoTip();
            fign.myFlagChangeAutoConfig = new fConfigAutoTip.GetFlagChangeAutoConfig(GetValueChangeAutoConfig);
            fign.ShowDialog();
          
        }

        private void GetValueChangeAutoConfig(bool val) {
         
            if (val == true)
            {
                myFlagChangeAutoConfig(true);
            }
        
        
        }
        public delegate void GetFlagChangeLanguage(bool flag);

        public GetFlagChangeLanguage myFlagChangeLanguage;

        private void langugesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fLanguages fign = new fLanguages();
            fign.myFlagChange = new fLanguages.GetFlagChang(GetValueOptionGetNumber);
            fign.ShowDialog();
        }

        private void GetValueOptionGetNumber(bool val) {
            if (val == true) {
                myFlagChangeLanguage(true);
            }
        
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbout f = new fAbout();
            f.ShowDialog();
        }
      
        private void bntTranslate_Click(object sender, EventArgs e)
        {
            try{
          
            }
            catch{
            }
        }
        private List<DataStoreModel> _listDic = new List<DataStoreModel>();
        private void GetDic() {
            Workbook book = Workbook.Load(@"Data\DataStore\1945 kanji.xls");
            Worksheet sheet = book.Worksheets[0];
            CellCollection cells=new CellCollection();
            cells=sheet.Cells;
            for (int i = 1,len=cells.Rows.Count; i < len; i++)
            {
                string japanese = cells[i,1].StringValue;
                string chinaViet = cells[i, 2].StringValue;
                string mean = cells[i, 3].StringValue;
                string Pronounce = cells[i, 4].StringValue;
                _listDic.Add(new DataStoreModel() { Japanese = japanese, Mean = chinaViet, Example = mean, Pronounce = Pronounce });
            }
           
        }
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string vocabulary=txtJapanese.Text;
            bool isFinded = false;
            if(!string.IsNullOrWhiteSpace(vocabulary)){
          
                foreach (var item in _listDic)
                {
                    if (vocabulary==item.Japanese) {
                        txtJapanese.Text = item.Japanese;
                        txtMean.Text = item.Mean;
                        //txtRemember.Text = item.Speak;
                        txtPronounce.Text = item.Pronounce;
                        txtExample.Text = item.Example;
                        isFinded = true;
                    }
                }
                if (isFinded == false) {
                    if (statusnotFound!=null)
                    txtJapanese.Text = statusnotFound;
                }
            
            }
        }

        private void danhSáchKanjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Data\DataStore\1945 kanji.xls");
        }

        private void btnAddFast_Click(object sender, EventArgs e)
        {
            try{
                if (!string.IsNullOrWhiteSpace(txtStart.Text))
                {
                    DataStoreModel _reModel = new DataStoreModel();
                    List<DataStoreModel> getDataStoreModels= _listDic.GetRange(Convert.ToInt32(txtStart.Text), Convert.ToInt32(txtEnd.Text));
                    foreach (DataStoreModel dataStoreModel in getDataStoreModels)
                    {
                        dataStoreModel.Id = Unitils.RandomGUID();
                        dataStoreModel.Date = dateDate.Value.ToString("dd/MM/yyyy");
                    }
                    _dataStoreEntity.AddByList(getDataStoreModels);
                    GetAll();
                    myFlagChange(true);
                    mainStatus.Text = (string)statusObj["AddSuccess"];
                }
                else
                {
                    mainStatus.Text = (string)statusObj["AddFaile"];
                }
            }
            catch 
            {
                mainStatus.Text = (string)statusObj["AddFaile"];
            }
            

        }

        private void btnFindByDay_Click(object sender, EventArgs e)
        {
            string strDateStart = dateDate.Value.ToString("dd/MM/yyyy");
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime dateStart = DateTime.ParseExact(strDateStart, "dd/MM/yyyy", provider);
            DateTime dateEnd = DateTime.ParseExact(strDateStart, "dd/MM/yyyy", provider);
            List<DataStoreModel> lis = _dataStoreEntity.GetByDate(dateStart, dateEnd);
            _showListView(lis);
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            using (var webClient = new System.Net.WebClient()) {
                if (string.IsNullOrWhiteSpace(txtNumerLession.Text)) return;
                var json = webClient.DownloadString(string.Format("http://japaneseclub.jp//eBooks/MinnaNihongo/Lesson-{0}/Vocabulary/Vocabulary-vi.json",txtNumerLession.Text));
                   List<VocabularyModel> m = JsonConvert.DeserializeObject<List<VocabularyModel>>(json);

                   foreach (var item in m)
                   {
                       try
                       {
                           DataStoreModel _reModel = new DataStoreModel();

                           _reModel.Id = Unitils.RandomGUID();
                           _reModel.Japanese = item.Hiragana;
                           _reModel.Pronounce = item.Category;
                           _reModel.Mean = item.Mean;
                           _reModel.Genre = item.Category;
                           _reModel.Date = dateDate.Value.ToString("dd/MM/yyyy");

                           if (!String.IsNullOrEmpty(txtChooseImage.Text))
                           {
                               if (!File.Exists(picImage.ImageLocation))
                               {
                                   System.IO.File.Copy(picImage.ImageLocation, Config.pictureFolder + imgTempUrl, true);
                               }
                               _reModel.Picture = imgTempUrl;
                           }
                           else
                           {
                               _reModel.Picture = "";
                           }

                           _dataStoreEntity.Add(_reModel);

                       }
                       catch (Exception ex)
                       {
                           string abc = ex.ToString();
                       }

                   }
                   GetAll();
                   myFlagChange(true);
                   mainStatus.Text = (string)statusObj["AddSuccess"];
                }
            
        }

      
    }
}
