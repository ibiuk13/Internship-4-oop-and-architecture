using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class CombatLogic
    {
        public static int FightLogic(int heroChoice, int monsterChoice)
        {
            var heroWin = 0;
            var monsterWin = 0;
            if (heroChoice == 1 && monsterChoice == 2)
            {
                heroWin = 1;
                return heroWin;
            }
            else if (heroChoice == 1 && monsterChoice == 3)
            {
                monsterWin = 2;
                return monsterWin;
            }

            else if (heroChoice == 2 && monsterChoice == 1)
            {
                monsterWin = 2;
                return monsterWin;
            }
            else if (heroChoice == 2 && monsterChoice == 3)
            {
                heroWin = 1;
                return heroWin;
            }
            else if (heroChoice == 3 && monsterChoice == 1)
            {
                heroWin = 1;
                return heroWin;
            }
            else if (heroChoice == 3 && monsterChoice == 2)
            {
                monsterWin = 2;
                return monsterWin;
            }
            else

                return 3;

        }
    }
}
