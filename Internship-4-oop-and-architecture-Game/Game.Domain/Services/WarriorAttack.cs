using Internship_4_oop_and_architecture_Game.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game.Domain.Services
{
    public class WarriorAttack
    {
        public static void WarriorAttacking(Hero userHero,Monster enemyMonster )
        {
            var attackOption = new int();
            string userChoice;
            bool inputStatus = false;
            do
            {
                Console.WriteLine("Izaberite vrstu napada : \n Obican napad = 1 \n Bijesni napad = 2 \n");
                userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out attackOption))
                {
                    if (attackOption == 1)
                        enemyMonster.MonsterHealthPoints = enemyMonster.MonsterHealthPoints - userHero.Damage;
                    else if (attackOption == 2)
                    {
                        enemyMonster.MonsterHealthPoints = enemyMonster.MonsterHealthPoints - userHero.Damage * 2;
                        userHero.HealthPoints = 0.85 * userHero.HealthPoints;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos");
                        inputStatus = false;
                        attackOption = int.Parse(userChoice);
                    }
                }
                else
                    Console.WriteLine("Krivi unos");

            } while ((int.TryParse(userChoice, out attackOption) == false) && inputStatus == false);
        }
    }
}
