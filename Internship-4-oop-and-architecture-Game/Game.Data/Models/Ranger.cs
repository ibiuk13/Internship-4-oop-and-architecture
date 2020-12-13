using Internship_4_oop_and_architecture_Game.Data.Enums;

namespace Internship_4_oop_and_architecture_Game.Data.Models
{
    public class Ranger : Hero
    {
        public double CriticalChance { get; set; }
        public double StunChance { get; set; }

        public static object CreateRanger(string name, double healthPoints, double experience, double damage, double mana)
        {
            var userHero = new Ranger
            {
                Name = name,
                HealthPoints = healthPoints,
                MaxHealthPoints = healthPoints,
                Experience = experience,
                Damage = damage,
                CriticalChance = 0.2,
                StunChance = 0.2,
                HeroType = HeroTypes.Ranger
            };
            return userHero;
        }
    }
}
