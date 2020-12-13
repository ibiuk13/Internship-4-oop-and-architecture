using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class CreatingMonsters
    {
        public static void CreatingEnemyMonsters(List<Monster> ListOfMonsters)
        {
            for (var i = 0; i < 10; i++)
            {
                Random random = new Random();
                var chance = random.Next(1,1001);
                if (chance < 601)
                {
                    var monster = new Goblin
                    {
                        MonsterHealthPoints = random.Next(1, 20),
                        MonsterDamage = random.Next(1, 10),
                        ExperienceValue = random.Next(1, 50),
                        MonsterType = MonsterTypes.Goblin
                    };
                    ListOfMonsters.Add(monster);
                }
                else if (chance >= 601 && chance < 901)
                {
                    var monster = new Brute
                    {
                        MonsterHealthPoints = random.Next(1, 75),
                        MonsterDamage = random.Next(1, 50),
                        ExperienceValue = random.Next(1, 50),
                        MonsterType = MonsterTypes.Brute
                    };
                    ListOfMonsters.Add(monster);
                }
                else
                {
                    var monster = new Witch
                    {
                        MonsterHealthPoints = random.Next(1, 70),
                        MonsterDamage = random.Next(1, 50),
                        ExperienceValue = random.Next(1, 50),
                        MonsterType = MonsterTypes.Witch
                    };
                    ListOfMonsters.Add(monster);
                }
            }
        }
    }
}
