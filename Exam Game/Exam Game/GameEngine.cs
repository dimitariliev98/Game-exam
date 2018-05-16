using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Game
{
    class GameEngine// Implements logic of the game
    {
        public static void fight (Hero warrior, Hero assassin) // Optional paramets
        {
            Console.WriteLine("---------------------------Arena starts right now!---------------------------");

                while (true)
                {
                Console.WriteLine(warrior.Name + " HP is: " + warrior.HealthPoints);
                assassin.Attack(warrior);

                if (warrior.isDead())
                {
                    break;
                }
                Console.WriteLine(assassin.Name + " HP is: " + assassin.HealthPoints);
                warrior.Attack(assassin);

                if (assassin.isDead())
                    {
                        break;
                    }
                }

            if (assassin.HealthPoints < warrior.HealthPoints)
            {
                Console.WriteLine("{0} WON the battle.", warrior.Name);
            }
            else if (assassin.HealthPoints > warrior.HealthPoints)
            {
                Console.WriteLine("{0} WON the battle.", assassin.Name);
            }
        }


    }
}
