using ConsoleApp4.Models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rasmda berilgan struktura asosida klasslarni yarating

            var person1 = new Goalie();
            person1.Sport = "dsakdla";
            person1.Team = "asfdsd";
            person1.GoalsPerGame();
        }
    }
}