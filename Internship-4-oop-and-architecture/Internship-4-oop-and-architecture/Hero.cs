using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture
{
     public class Hero
    {
        public string Name { get; set; }
        public double HealthPoints { get; set; }
        public int Experience { get; set; }
        public double Damage { get; set; }
        public HeroTypeEnum HeroType { get; set; }

        public void Attack()
        {

        }
    }
}
