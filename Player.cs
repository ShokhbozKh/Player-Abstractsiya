using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Player
    {
        public abstract string Sport { get; set; }
        public abstract string Team { get; set; }
        public abstract string Position { get; set; }
        public abstract string First { get; set; }
        public abstract string Last { get; set; }
    }
}
