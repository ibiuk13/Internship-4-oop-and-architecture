using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class Mage : Hero
    {
        public double Mana { get; set; }
        public static object CreateMage(string name, double healthPoints, double experience, double damage, double mana)
        {
            var userHero = new Mage
            {
                Name = name,
                HealthPoints = healthPoints,
                MaxHealthPoints = healthPoints,
                Experience = experience,
                Damage = damage,
                Mana = mana,
                HeroType = HeroTypes.Mage
            };
            return userHero;
        }
    }
}
