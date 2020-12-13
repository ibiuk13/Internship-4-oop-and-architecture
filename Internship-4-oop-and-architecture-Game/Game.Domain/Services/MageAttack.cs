using Internship_4_oop_and_architecture_Game.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game.Domain.Services
{
    public class MageAttack
    {
        public static void MageAttacking(Mage userHero, Monster enemyMonster)
        {
            if (userHero.Mana > 0)
            {
                enemyMonster.MonsterHealthPoints -= userHero.Damage;
                userHero.Mana -= 10;
            }
            else userHero.Mana = 100;

        }
    }
}
