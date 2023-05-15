using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Player
    {
        public string Name { get; set; }
        public bool Captain { get; set; }
        public int ShirtNumber { get; set; }
        public string Position { get; set; }

        public string GetName()
            => $"{Name}";
    }
}
