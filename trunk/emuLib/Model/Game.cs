using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emuLib
{
    class Game
    {
        public string name { get; set; }
        public uint crc { get; set; }
        public string manufacturer { get; set; }
        public uint year { get; set; }
        public string genre { get; set; }
        public bool hasManual { get; set; }

        public Game()
        {

        }

        public Game(string name)
        {
            this.name = name;
        }

        public Game(string name, uint crc, string manufacturer, uint year, string genre)
        {
            this.name = name;
            this.crc = crc;
            this.manufacturer = manufacturer;
            this.year = year;
            this.genre = genre;
        }
    }
}
