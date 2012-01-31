using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using emuLib.Libraries;

namespace emuLib
{
    static class Repo
    {
        public static GameLib snesLib { get; set; }     
        public static Size smallIconSize { get { return new Size(64, 53); } }
        public static Size largeIconSize { get { return new Size(128, 106); } }

        public static string bsnesLocation { get; set; }
        public static string snesXmlLocation { get; set; }
        public static string snesRomLocation { get; set; }

        internal static void loadSettings()
        {
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.ini");
            string filename2 = ".\\settings.ini";

            if (File.Exists(filename2))
            {
                INIFile ini = new INIFile(filename2);
                bsnesLocation = ini.IniReadValue("settings", "bsnes");
                snesXmlLocation = ini.IniReadValue("settings", "xml");
                snesRomLocation = ini.IniReadValue("settings", "roms");
            }
            else if (File.Exists(filename))
            {
                INIFile ini = new INIFile(filename);
                bsnesLocation = ini.IniReadValue("settings", "bsnes");
                snesXmlLocation = ini.IniReadValue("settings", "xml");
                snesRomLocation = ini.IniReadValue("settings", "roms");
            }
        }

        internal static void saveSettings()
        {
            string dirname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib");
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.ini");
            string filename2 = ".\\settings.ini";

            if (File.Exists(filename2))
            {
                INIFile ini = new INIFile(filename2);
                ini.IniWriteValue("settings", "bsnes", bsnesLocation);
                ini.IniWriteValue("settings", "xml", snesXmlLocation);
                ini.IniWriteValue("settings", "roms", snesRomLocation);
            }
            else
            {
                if (!Directory.Exists(dirname))
                    Directory.CreateDirectory(dirname);
                INIFile ini = new INIFile(filename);
                ini.IniWriteValue("settings", "bsnes", bsnesLocation);
                ini.IniWriteValue("settings", "xml", snesXmlLocation);
                ini.IniWriteValue("settings", "roms", snesRomLocation);
            }
        }
    }
}
