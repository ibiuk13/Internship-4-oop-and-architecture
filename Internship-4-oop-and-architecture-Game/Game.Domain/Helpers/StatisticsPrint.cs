using Internship_4_oop_and_architecture_Game.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game.Domain.Helpers
{
    public class StatisticsPrint
    {
        public static void HeroAndMonsterStatsPrint(Hero userHero, Monster enemyMonster)
        {
            Console.WriteLine(userHero.Name + "'s HP: " + userHero.HealthPoints +
                "\nExperience: " + userHero.Experience);
            Console.WriteLine(enemyMonster.MonsterType + "'s HP: " + enemyMonster.MonsterHealthPoints);
        }
    }
}
