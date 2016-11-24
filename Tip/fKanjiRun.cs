using ExcelLibrary.SpreadSheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tip.Models;

namespace Tip
{
    public partial class fKanjiRun : Form
    {
        public fKanjiRun()
        {
            InitializeComponent();
            tmKanjiRun.Interval = tbSpeed.Value * 1000;
            tmKanjiRun.Stop();
            tmKanjiRun.Start();
            
        }
        private List<DataStoreModel> _listDic = new List<DataStoreModel>();
        private void GetDic()
        {
            Workbook book = Workbook.Load(@"Data\DataStore\1945 kanji.xls");
            Worksheet sheet = book.Worksheets[0];
            CellCollection cells = new CellCollection();
            cells = sheet.Cells;
            for (int i = 1, len = cells.Rows.Count; i < len; i++)
            {
                string japanese = cells[i, 1].StringValue;
                string chinaViet = cells[i, 2].StringValue;
                string mean = cells[i, 3].StringValue;
                string Pronounce = cells[i, 4].StringValue;
                _listDic.Add(new DataStoreModel() { Japanese = japanese, Mean = chinaViet, Example = mean, Pronounce = Pronounce });
            }

        }
        private void fKanjiRun_Load(object sender, EventArgs e)
        {
            GetDic();
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            tmKanjiRun.Interval = tbSpeed.Value * 1000;
            tmKanjiRun.Stop();
            tmKanjiRun.Start();
        }

        private void tmKanjiRun_Tick(object sender, EventArgs e)
        {
           
            
        }
    }
}
