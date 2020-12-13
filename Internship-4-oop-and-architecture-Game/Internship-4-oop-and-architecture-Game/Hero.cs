using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class Hero
    {

        public string Name { get; set; }
        public double HealthPoints { get; set; }
        public double MaxHealthPoints { get; set; }
        public double Experience { get; set; }
        public double Damage { get; set; }
        public HeroTypes HeroType { get; set; }
        public void LevelUp()
        {
            if(Experience>100)
            {
                Console.WriteLine("Level up!");
                Experience = Experience % 100;
                HealthPoints += 0.25 * MaxHealthPoints;
            }
        }

    }
}
