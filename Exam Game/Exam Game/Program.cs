using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Godlike", 1850, 160, 140);
            Assassin assassin = new Assassin("ForceGirl", 800, 200, 75);
            Assassin assassin2 = new Assassin("DifferentPerson", 2000, 200, 30);
            Mage mage1 = new Mage("FirstMage", 1200, 250, 50);

            GameEngine.fight(mage1, warrior);

            Console.ReadKey();
        }
    }
}
