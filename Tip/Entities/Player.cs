using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tip.Entities
{
    public class Player
    {
            WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer();

            public void play(string Url)
            {
                a.URL = Url;
                a.controls.play();
                a.settings.volume = 100;
               // a.settings.setMode("loop", true);
            }
            public void pause()
            {
                a.controls.pause();
            }
            public void stop()
            {
                a.controls.stop();
            }
        }
    
}
