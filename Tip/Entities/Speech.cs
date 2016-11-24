using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Speech.Synthesis;
using System.Text;


namespace Tip.Entities
{
    public  class Speech
    {

      
        public static void PlayMp3FromUrl(string url)
       {
        using (Stream ms = new MemoryStream())
        {
            using (Stream stream = WebRequest.Create(url)
                .GetResponse().GetResponseStream())
            {
                byte[] buffer = new byte[32768];
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
            }

            //ms.Position = 0;
            //using (WaveStream blockAlignedStream =
            //    new BlockAlignReductionStream(
            //        WaveFormatConversionStream.CreatePcmStream(
            //            new Mp3FileReader(ms))))
            //{
            //    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
            //    {
            //        waveOut.Init(blockAlignedStream);
            //        waveOut.PlaybackStopped += (sender, e) =>
            //        {
            //            waveOut.Stop();
            //        };

            //        waveOut.Play();
                   
                 
            //    }
            //}
        }
    }


        public static void GoogleSpeak(string lang,string text)
        {
            var client = new WebClient();

            var stream = client.OpenRead("http://translate.google.com.vn/translate_tts?ie=UTF-8&q=" + text + "&tl=" + lang + "&total=1&idx=0&textlen=3&prev=input");
            client.Headers["User-Agent"] =
               "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
               "(compatible; MSIE 6.0; Windows NT 5.1; " +
               ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

          
         
        }

        public static void SapiSpeak(string text)
        {

            MemoryStream memoryStream = new MemoryStream();

            var t = new System.Threading.Thread(() =>
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Speak(text);
             

            });
            t.Start();
            t.Join();

       
        }


    }
}
