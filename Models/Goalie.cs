using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Goalie:SoccerPlayer
    {
        public int GoalsAllowed { get; set; } = 12;
        public double AverageGoalsAllawed { get; set; } = 21;
    }
}
