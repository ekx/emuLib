using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace emuLib
{
    class GameLib
    {
        public string dir { get; set; }
        public string system { get; set; }
        private ArrayList games = new ArrayList();
        private ImageList boxes = new ImageList();

        public GameLib(string system, string dir, string xmlFile)
        {
            this.system = system;
            this.dir = dir;

            parseFromXmlFile(xmlFile);
            buildImageList(dir);
        }

        public void addGame(Game game)
        {
            games.Add(game);
        }

        public void removeGame(Game game)
        {
            games.Remove(game);
        }

        public Game getGame(int index)
        {
            return (Game)games[index];
        }

        public ArrayList getGames()
        {
            return games;
        }

        public String getDescription(string key)
        {
            if (!File.Exists(dir + key + "\\description.txt"))
                return "Description missing...";
            StreamReader sr = new StreamReader(dir + key + "\\description.txt");
            string descr = sr.ReadToEnd();
            sr.Close();

            return descr;
        }

        public void openManual(string key)
        {
            if (File.Exists(dir + key + "\\manual.pdf"))
            {
                Process.Start(dir + key + "\\manual.pdf");
            }
            else
                MessageBox.Show("The manual for this game is missing", "Error");
        }

        public Image getCartridgeArt(string key)
        {
            if (File.Exists(dir + key + "\\cartridge.png"))
                return Image.FromFile(dir + key + "\\cartridge.png");

            return null;
        }

        public ImageList getBoxArt()
        {
            return boxes;
        }

        public Image getBoxArt(string key)
        {
            if (File.Exists(dir + key + "\\box.png"))
                return Image.FromFile(dir + key + "\\box.png");

            return null;
        }

        public string getRomPath(string key)
        {
            return (dir + key + "\\rom.sfc");
        }

        private void parseFromXmlFile(string filename)
        {
            if(File.Exists(filename))
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(filename);

                XmlNodeList names = xd.GetElementsByTagName("description");
                XmlNodeList crcs = xd.GetElementsByTagName("crc");
                XmlNodeList manufacturers = xd.GetElementsByTagName("manufacturer");
                XmlNodeList years = xd.GetElementsByTagName("year");
                XmlNodeList genres = xd.GetElementsByTagName("genre");

                for (int i = 0; i < names.Count; i++)
                {
                    games.Add(new Game(names[i].InnerText, Convert.ToUInt32(crcs[i].InnerText, 16), manufacturers[i].InnerText, uint.Parse(years[i].InnerText), genres[i].InnerText));
                }
            }
        }

        private void buildImageList(string dir)
        {
            string[] dirs = Directory.GetDirectories(dir);

            for (int i = 0; i < games.Count; i++)
            {
                if(File.Exists(dir + ((Game)games[i]).name + "\\box.png"))
                {
                    boxes.Images.Add(((Game)games[i]).name, Image.FromFile(dir + ((Game)games[i]).name + "\\box.png"));
                }
            }

            boxes.ImageSize = Repo.largeIconSize;
            boxes.ColorDepth = ColorDepth.Depth32Bit;
        }
    }
}
