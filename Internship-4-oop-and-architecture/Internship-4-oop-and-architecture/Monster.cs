
using System;

namespace Internship_4_oop_and_architecture
{
    
     public class Monster
     {
       double MonsterHealthPoints { get; set; }
       double MonsterDamage { get; set; }
        public static void GenerateMonsterValues(double MonsterHealthPoints, double MonsterDamage)
        {
            Random rand = new Random();
            MonsterHealthPoints = rand.Next(1, 101);
            MonsterDamage = rand.Next(1, 101);

        }
    }
   
}
