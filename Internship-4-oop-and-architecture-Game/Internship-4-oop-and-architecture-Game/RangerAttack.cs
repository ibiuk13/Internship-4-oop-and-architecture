using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class RangerAttack
    {
        public static void RangerAttacking(Ranger userHero, Monster enemyMonster)
        {
            Random random = new Random();
            var chance = random.Next(1, 11);
            if (chance == 1)
            {
                Console.WriteLine("Critical hit");
                enemyMonster.MonsterHealthPoints -= 200;
            }
            else if (chance == 2)
            {
                Console.WriteLine("Stun!");
                enemyMonster.MonsterHealthPoints -= userHero.Damage;


            }
            else enemyMonster.MonsterHealthPoints -= userHero.Damage;
        }
    }
}
