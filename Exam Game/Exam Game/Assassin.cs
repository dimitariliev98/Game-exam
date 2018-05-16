using System;
using System.Threading;

namespace Exam_Game
{
    public class Assassin : Hero
    {



        public Assassin()
        {

        }

        public Assassin(string Name, int HealthPoints, int AttackPoints, int ArmorPoints)
        {
            this.Name = Name;
            this.HealthPoints = HealthPoints;
            this.AttackPoints = AttackPoints;
            this.ArmorPoints = ArmorPoints;
        }
        public override int randomDamage()
        {
            Random random = new Random();
            Thread.Sleep(1000);
            int specialAttack = random.Next(1, 101);
            if (specialAttack >= 30)
            {
               return AttackPoints * (random.Next(80, 120)) / 100;
            }
            else
            {
               return (AttackPoints * (random.Next(80, 120)) / 100) * 3; // There is 30% chance to deal 300% of its damage 
            }
        }
    }
}

