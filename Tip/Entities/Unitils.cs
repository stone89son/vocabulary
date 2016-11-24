using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;


namespace Tip.Entities
{
    public  class Unitils
    {
        public static void ExportXmlTemp(string _pathFileTemp, DataTable dt)
        {
            dt.WriteXml(_pathFileTemp);
        }

        public static void ResetAll(string fileConfig)
        {
            DataTable dtFileLog = new DataTable();
            dtFileLog.TableName = "Entity";
            Unitils.ExportXmlTemp(fileConfig, dtFileLog);
        }

        public static string MilliTimeStamp()
        {
            //Int64 retval = 0;
            //DateTime st = new DateTime(1970, 1, 1);
            //TimeSpan t = (DateTime.Now.ToUniversalTime() - st);
            //retval = (Int64)(t.TotalMilliseconds + 0.5);

            return DateTime.Now.Ticks.ToString();
        }

        public static string RandomGUID()
        {
            //Int64 retval = 0;
            //DateTime st = new DateTime(1970, 1, 1);
            //TimeSpan t = (DateTime.Now.ToUniversalTime() - st);
            //retval = (Int64)(t.TotalMilliseconds + 0.5);
            Guid id = Guid.NewGuid();
            return id.ToString();
        }

        public static void DeleteAll(string path){

               System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(path);
                foreach(System.IO.FileInfo file in directory.GetFiles())file.Delete();
                foreach(System.IO.DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);
        
        }

        public static bool SaveSound(string nameSound){
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://translate.google.com/translate_tts?tl=en&q=" + nameSound + "", Config.soundFolder + nameSound + ".mp3");
                return true;
            }
            catch {
                return false;
            }
        }
        

    }
}
