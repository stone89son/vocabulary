using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using System.Windows.Forms;
namespace Tip.Entities
{
    public class ProgramInit
    {

       
        public DateTime GetDateStart()
        {
            IniFile ini = new IniFile(Config.configFile);
             CultureInfo provider = CultureInfo.InvariantCulture;
             string dat = ini.IniReadValue("Options", "DateStart");
           
            return DateTime.ParseExact(ini.IniReadValue("Options", "DateStart"),"dd/MM/yyyy",provider);
        }
        
        public void SetDateStart(DateTime date)
        {
            IniFile ini = new IniFile(Config.configFile);
            ini.IniWriteValue("Options", "DateStart", date.ToString("dd/MM/yyyy"));
        }

        public DateTime GetDateEnd()
        {
            IniFile ini = new IniFile(Config.configFile);

            CultureInfo provider = CultureInfo.InvariantCulture;

            return DateTime.ParseExact(ini.IniReadValue("Options", "DateEnd"), "dd/MM/yyyy", provider);
        }

        public void SetDateEnd(DateTime date)
        {
            IniFile ini = new IniFile(Config.configFile);
            ini.IniWriteValue("Options", "DateEnd", date.ToString("dd/MM/yyyy"));
        }

        public void SetTimer(Int16 time)
        {
            IniFile ini = new IniFile(Config.configFile);
            ini.IniWriteValue("Options", "TimeAuto", time.ToString());
        }

        public Int16 GetTimer()
        {
           IniFile ini = new IniFile(Config.configFile);
          return Convert.ToInt16(ini.IniReadValue("Options", "TimeAuto"));
        }
        public string GetLang()
        {
            IniFile ini = new IniFile(Config.configFile);
            return (ini.IniReadValue("Options", "Language"));
        }
        public void SetLang(string idLang)
        {
            IniFile ini = new IniFile(Config.configFile);
            ini.IniWriteValue("Options", "Language", idLang);
        }


    }
}
