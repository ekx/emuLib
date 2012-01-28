using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.dat");
            string filename2 = "settings.dat";

            if (File.Exists(filename2))
            {
                Stream stream = File.Open(filename2, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bsnesLocation = (string)bFormatter.Deserialize(stream);
                snesXmlLocation = (string)bFormatter.Deserialize(stream);
                snesRomLocation = (string)bFormatter.Deserialize(stream);
                stream.Close();
            }
            else if (File.Exists(filename))
            {
                Stream stream = File.Open(filename, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bsnesLocation = (string)bFormatter.Deserialize(stream);
                snesXmlLocation = (string)bFormatter.Deserialize(stream);
                snesRomLocation = (string)bFormatter.Deserialize(stream);
                stream.Close();
            }
        }

        internal static void saveSettings()
        {
            string dirname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib");
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "emuLib", "settings.dat");
            string filename2 = "settings.dat";

            if (File.Exists(filename2))
            {
                Stream stream = File.Open(filename, FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, bsnesLocation);
                bFormatter.Serialize(stream, snesXmlLocation);
                bFormatter.Serialize(stream, snesRomLocation);
                stream.Close();
            }
            else
            {
                if (!Directory.Exists(dirname))
                    Directory.CreateDirectory(dirname);
                Stream stream = File.Open(filename, FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, bsnesLocation);
                bFormatter.Serialize(stream, snesXmlLocation);
                bFormatter.Serialize(stream, snesRomLocation);
                stream.Close();
            }
        }
    }
}
