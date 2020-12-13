using Internship_4_oop_and_architecture_Game.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game.Data.Models
{
     public class Monster
    {    
        public double MonsterHealthPoints { get; set; }
        public double MonsterDamage { get; set; }
        public double ExperienceValue { get; set; }
        public MonsterTypes MonsterType { get; set; }

    }
}
