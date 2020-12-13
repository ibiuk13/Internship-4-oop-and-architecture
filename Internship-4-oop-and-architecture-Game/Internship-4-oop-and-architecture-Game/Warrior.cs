using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
     public class Warrior : Hero
    {
        public static object CreateWarrior(string name, double healthPoints, double experience, double damage)
        {
            var userHero = new Warrior
            {
                Name = name,
                HealthPoints = healthPoints,
                MaxHealthPoints = healthPoints,
                Experience = experience,
                Damage = damage,
                HeroType = HeroTypes.Warrior
            };
            return userHero;
        }
    }
}
