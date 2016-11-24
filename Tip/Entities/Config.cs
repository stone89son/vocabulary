using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tip.Entities
{
    public  class Config
    {
        public static string dataFolder = @"Data\";

        public static string pictureFolder = dataFolder + @"Pictures\";
        public static string soundFolder = dataFolder + @"Sounds\";
        public static string dataStoreFile = dataFolder + @"DataStore\DataStoreFile.xml";
        public static string configFile = @"Config\Config.ini";
        public static string picNoVarible = "noImageAvailable.JPG";
        
    }
}
