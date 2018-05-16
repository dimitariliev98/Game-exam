using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Game
{
    public class Mage : Hero
    {
        public Mage()
        {

        }

        public Mage(string Name, int HealthPoints, int AttackPoints, int ArmorPoints)
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
            if (specialAttack >= 45)
            {
                return AttackPoints * (random.Next(80, 120)) / 100;
            }
            else
            {
                return ((AttackPoints * (random.Next(80, 120)) / 100) * 150) / 100; // There is 45% chance to deal 150% of its damage 
            }
        }
    }
}
