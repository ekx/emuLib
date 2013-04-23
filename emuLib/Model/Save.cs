using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emuLib.Model
{
    class Save
    {
        public string filename { get; set; }
        public SaveType type { get; set; }
        public string savename { get; set; }
        public int nr { get; set; }
        public DateTime date { get; set; }

        public Save(string filename, SaveType type, string savename, int nr, DateTime date)
        {
            this.filename = filename;
            this.type = type;
            this.savename = savename;
            this.nr = nr;
            this.date = date;
        }
    }

    enum SaveType
    {
        Normal,
        StateManager
    }
}
