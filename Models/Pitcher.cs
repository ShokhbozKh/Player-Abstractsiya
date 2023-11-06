using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Pitcher:BaseballPlayer
    {
        public double Innings { get; set; } = 21;
        public int EarnedRuns { get; set; } = 12;
        public int EarnedRunAverage()
        {
            return EarnedRuns / (int)Innings;

        }
    }
}
