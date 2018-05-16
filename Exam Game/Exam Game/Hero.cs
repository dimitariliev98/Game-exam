using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_Game
{
    public abstract class Hero
    {
        private string name;
        private int healthPoints;
        private int attackPoints;
        private int armorPoints;

 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }

        public int AttackPoints
        {
            get
            {
                return attackPoints;
            }
            set
            {
                attackPoints = value;
            }
        }

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                armorPoints = value;
            }
        }

        public virtual int randomDamage()
        {
            Random random = new Random();
            Thread.Sleep(1000);
            return AttackPoints * (random.Next(80, 120)) / 100;
        }
        public bool isDead()
        {
            if (HealthPoints <= 0)
                return true;
            else
                return false;
        }
        public virtual void Attack(Hero hero1)
        {
            int damage = randomDamage();
            hero1.HealthPoints = hero1.HealthPoints - Defend(damage);
        }

        public int Defend(int damage)
        {
            Random randomDefense = new Random();
            int takenDamage = damage - (ArmorPoints * randomDefense.Next(80, 120)) / 100;
            return takenDamage;
        }

    }

}
