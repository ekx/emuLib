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
using emuLib.Model;
using System.Runtime.Serialization;
using emuLib.Forms;

namespace emuLib
{
    [Serializable()]
    class GameLib : ISerializable
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

        public GameLib(SerializationInfo info, StreamingContext ctxt)
        {
            this.dir = (string)info.GetString("Dir");
            this.system = (string)info.GetString("System");
            this.games = (ArrayList)info.GetValue("Games", typeof(ArrayList));

            this.boxes.ImageStream = (ImageListStreamer)info.GetValue("Boxes", typeof(ImageListStreamer));

            for (int i = 0; i < boxes.Images.Count; i++)
            {
                boxes.Images.SetKeyName(i, ((Game)games[i]).name);
            }

            this.boxes.ImageSize = Repo.largeIconSize;
            this.boxes.ColorDepth = ColorDepth.Depth32Bit;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Dir", this.dir);
            info.AddValue("System", this.system);
            info.AddValue("Games", this.games);

            info.AddValue("Boxes", this.boxes.ImageStream);
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

        public ArrayList getSaveList(string key)
        {
            if (Directory.Exists(dir + key + ".sfc\\bsnes"))
            {
                String[] temp;
                ArrayList res = new ArrayList();
                temp = Directory.GetFiles(dir + key + ".sfc\\bsnes");

                for (int i = 0; i < temp.Length; i++)
                {
                    String f = Path.GetFileNameWithoutExtension(temp[i]);
   
                    if (f.Contains("state-"))
                    {
                        f = f.Replace("state-", "");
                        int nr = Int32.Parse(f);
                        res.Add(new Save(temp[i], SaveType.Normal, "State " + nr, nr, File.GetLastWriteTime(temp[i])));
                    }
                    else if (f.Equals("states"))
                    {
                        BinaryReader br = new BinaryReader(File.Open(temp[i], FileMode.Open));
                        br.BaseStream.Position = 8;

                        for(int j = 1; j <= 32; j++)
                        {
                            if (br.ReadByte() != 1)
                                continue;

                            UInt32 size = br.ReadUInt32();

                            br.BaseStream.Position += 4;
                            size -= 4;
                            br.BaseStream.Position += 4;
                            size -= 4;
                            br.BaseStream.Position += 64;
                            size -= 64;

                            char[] desc = br.ReadChars(512);
                            size -= 512;

                            res.Add(new Save(temp[i], SaveType.StateManager, new string(desc).Replace("\0", ""), j, File.GetLastWriteTime(temp[i])));

                            br.BaseStream.Position += size;
                        }

                        br.BaseStream.Close();
                        br.Close();
                    }
                }

                return res;
            }

            return null;
        }

        public String getDescription(string key)
        {
            if (!File.Exists(dir + key + ".sfc\\description.txt"))
                return "Description missing...";
            StreamReader sr = new StreamReader(dir + key + ".sfc\\description.txt");
            string descr = sr.ReadToEnd();
            sr.Close();

            return descr;
        }

        public void openManual(string key)
        {
            if (File.Exists(dir + key + ".sfc\\manual.pdf"))
            {
                Process.Start(dir + key + ".sfc\\manual.pdf");
            }
            else
                MessageBox.Show("The manual for this game is missing", "Error");
        }

        public Image getCartridgeArt(string key)
        {
            if (File.Exists(dir + key + ".sfc\\cartridge.png"))
                return Image.FromFile(dir + key + ".sfc\\cartridge.png");

            return null;
        }

        public ImageList getBoxArt()
        {
            return boxes;
        }

        public Image getBoxArt(string key)
        {
            if (File.Exists(dir + key + ".sfc\\box.png"))
                return Image.FromFile(dir + key + ".sfc\\box.png");

            return null;
        }

        public string getRomPath(string key)
        {
            //return (dir + key + ".sfc\\program.rom");
            return (dir + key + ".sfc");
        }

        private void parseFromXmlFile(string filename)
        {
            if (File.Exists(filename))
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
            ProgressDialog pd = new ProgressDialog(games.Count);

            pd.Show();

            for (int i = 0; i < games.Count; i++)
            {
                if (File.Exists(dir + ((Game)games[i]).name + ".sfc\\box.png"))
                {
                    boxes.Images.Add(((Game)games[i]).name, Image.FromFile(dir + ((Game)games[i]).name + ".sfc\\box.png"));
                }

                pd.setStep(i + 1);
            }

            pd.Close();

            boxes.ImageSize = Repo.largeIconSize;
            boxes.ColorDepth = ColorDepth.Depth32Bit;
        }
    }
}
