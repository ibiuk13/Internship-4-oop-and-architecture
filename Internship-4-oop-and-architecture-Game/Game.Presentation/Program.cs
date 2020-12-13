using Internship_4_oop_and_architecture_Game.Data.Enums;
using Internship_4_oop_and_architecture_Game.Data.Models;
using Internship_4_oop_and_architecture_Game.Domain.Helpers;
using Internship_4_oop_and_architecture_Game.Domain.Services;
using System;
using System.Collections.Generic;

namespace Internship_4_oop_and_architecture_Game.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userHero = new Hero();
            userHero = CreatingHero.UserCreatingHero(userHero);
            var ListOfMonsters = new List<Monster>();
            CreatingMonsters.CreatingEnemyMonsters(ListOfMonsters);
            if (userHero.HeroType == HeroTypes.Warrior)
            {
                for (var i = 0; i < ListOfMonsters.Count; i++)
                {
                    do
                    {
                        var userChoice = HeroAttack.HeroAttacking();
                        var monsterChoice = MonsterAttack.MonsterAttacking();
                        var fightStatus = CombatLogic.FightLogic(userChoice, monsterChoice);
                        if (fightStatus == 1)
                        {
                            Console.WriteLine("Heroj pobjeduje");
                            if (userHero.HeroType == HeroTypes.Warrior) WarriorAttack.WarriorAttacking((Warrior)userHero, ListOfMonsters[i]);
                            else if (userHero.HeroType == HeroTypes.Mage) MageAttack.MageAttacking((Mage)userHero, ListOfMonsters[i]);
                            else RangerAttack.RangerAttacking((Ranger)userHero, ListOfMonsters[i]);
                        }
                        else if (fightStatus == 2)
                        {
                            Console.WriteLine("Cudoviste pobjeduje");
                            if (ListOfMonsters[i].MonsterType == MonsterTypes.Goblin || (ListOfMonsters[i].MonsterType == MonsterTypes.Brute))
                                userHero.HealthPoints = MonsterAttack.RegularAttack(userHero.HealthPoints, ListOfMonsters[i].MonsterDamage);
                            else userHero.HealthPoints = MonsterAttack.WitchAttack(userHero.HealthPoints, ListOfMonsters[i].MonsterDamage, ListOfMonsters);
                        }
                        else Console.WriteLine("Izjednaceno");
                        StatisticsPrint.HeroAndMonsterStatsPrint(userHero, ListOfMonsters[i]);
                    } while (userHero.HealthPoints >= 0 && ListOfMonsters[i].MonsterHealthPoints >= 0);
                    if (ListOfMonsters[i].MonsterHealthPoints <= 0)
                    {
                        Console.WriteLine("Cudoviste je porazeno");
                        userHero.HealthPoints += 0.25 * userHero.MaxHealthPoints;
                        if (i < ListOfMonsters.Count - 1) Console.WriteLine("Iduce cudoviste je: " + ListOfMonsters[i + 1].MonsterType);
                        else Console.WriteLine("Pobijedili ste!");
                        userHero.Experience += ListOfMonsters[i].ExperienceValue;
                        userHero.LevelUp();
                    }
                    if (userHero.HealthPoints <= 0) Console.WriteLine("Izgubili ste");

                }
            }
        }
    }
}
