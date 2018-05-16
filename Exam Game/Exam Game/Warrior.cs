using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exam_Game
{
    public class Warrior : Hero
    {
        public Warrior()
        {

        }

        public Warrior(string Name, int HealthPoints, int AttackPoints, int ArmorPoints)
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
            return AttackPoints * (random.Next(80, 120)) / 100;
        }
        public override void Attack(Hero hero1)
        {
            int damage = randomDamage();
            hero1.HealthPoints -= damage;
        }
        
    }
}
