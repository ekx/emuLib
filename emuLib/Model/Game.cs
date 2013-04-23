using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace emuLib
{
    [Serializable()]
    class Game : ISerializable
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

        public Game(SerializationInfo info, StreamingContext ctxt)
        {
            this.name = info.GetString("Name");
            this.crc = info.GetUInt32("CRC");
            this.manufacturer = info.GetString("Manufacturer");
            this.year = info.GetUInt32("Year");
            this.genre = info.GetString("Genre");
            this.hasManual = info.GetBoolean("HasManual");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Name", this.name);
            info.AddValue("CRC", this.crc);
            info.AddValue("Manufacturer", this.manufacturer);
            info.AddValue("Year", this.year);
            info.AddValue("Genre", this.genre);
            info.AddValue("HasManual", this.hasManual);
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
