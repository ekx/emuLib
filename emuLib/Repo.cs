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
        public static readonly string FILENAME = "snes.lib";

        public static GameLib snesLib { get; set; }     
        public static Size smallIconSize { get { return new Size(64, 53); } }
        public static Size largeIconSize { get { return new Size(128, 106); } }

        public static string bsnesLocation { get; set; }

        internal static void serializeGameLib()
        {
            Stream stream = File.Open(FILENAME, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, snesLib);
            stream.Close();
        }

        internal static void deserializeGameLib()
        {
            Stream stream = File.Open(FILENAME, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            snesLib = (GameLib)bFormatter.Deserialize(stream);
            stream.Close();
        }

        internal static void loadSettings()
        {
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.ini");
            string filename2 = ".\\settings.ini";

            if (File.Exists(filename2))
            {
                INIFile ini = new INIFile(filename2);
                bsnesLocation = ini.IniReadValue("settings", "bsnes");
            }
            else if (File.Exists(filename))
            {
                INIFile ini = new INIFile(filename);
                bsnesLocation = ini.IniReadValue("settings", "bsnes");
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
            }
            else
            {
                if (!Directory.Exists(dirname))
                    Directory.CreateDirectory(dirname);
                INIFile ini = new INIFile(filename);
                ini.IniWriteValue("settings", "bsnes", bsnesLocation);
            }
        }

        public static void saveSelectedView(string type)
        {
            string dirname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib");
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.ini");
            string filename2 = ".\\settings.ini";

            if (File.Exists(filename2))
            {
                INIFile ini = new INIFile(filename2);
                ini.IniWriteValue("settings", "view", type);
            }
            else
            {
                if (!Directory.Exists(dirname))
                    Directory.CreateDirectory(dirname);
                INIFile ini = new INIFile(filename);
                ini.IniWriteValue("settings", "view", type);
            }
        }

        public static string loadSelectedView()
        {
            string res = null;

            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.ini");
            string filename2 = ".\\settings.ini";

            if (File.Exists(filename2))
            {
                INIFile ini = new INIFile(filename2);
                res = ini.IniReadValue("settings", "view");
            }
            else if (File.Exists(filename))
            {
                INIFile ini = new INIFile(filename);
                res = ini.IniReadValue("settings", "view");
            }

            return res;
        }
    }
}
