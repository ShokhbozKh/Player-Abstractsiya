using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class BaseballPlayer : Player
    {
        public override string Sport { get; set; } = "bbc";
        public override string Team { get; set; } = "teram bbc";
        public override string Position { get ;set; } = "center";
        public override string First { get; set; } = "attack";
        public override string Last { get; set; } = "hand";
        public int AtBats { get; set; }
        public int Hits { get; set; }

        public double BattingAverage()
        {
            return AtBats / Hits;
        }

    }
}
