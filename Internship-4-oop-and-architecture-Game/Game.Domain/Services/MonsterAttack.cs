using Internship_4_oop_and_architecture_Game.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game.Domain.Services
{
    public class MonsterAttack
    {
        public static int MonsterAttacking()
        {
            Random rand = new Random();
            var monsterPick = rand.Next(1, 4);
            return monsterPick;
        }
        public static double RegularAttack(double heroHealth, double monsterDamage)
        {
            heroHealth -= monsterDamage;
            return heroHealth;
        }
        public static double WitchAttack(double heroHealth, double monsterDamage, List<Monster> ListOfMonsters)
        {
            Random rand = new Random();
            var chance = rand.Next(1, 101);
            if (chance < 81) RegularAttack(heroHealth, monsterDamage);
            else
            {
                Console.WriteLine("Đumbus");
                heroHealth = rand.Next(1, 101);
                foreach (var monster in ListOfMonsters)
                {
                    monster.MonsterHealthPoints = rand.Next(1, 101);
                }
            }
            return heroHealth;
        }
    }
}
