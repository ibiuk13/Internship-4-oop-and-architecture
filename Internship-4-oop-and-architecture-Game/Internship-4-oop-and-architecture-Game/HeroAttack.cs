using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class HeroAttack
    {
        public static int HeroAttacking()
        {
            var heroPick = new int();
            string userInput;
            bool inputStatus = false;
            do
            {
                Console.WriteLine("Kako želite napasti čudovište: \n" +
                "Direktan napad (Kamen) = 1 \n" +
                "Napad s boka(Škare) = 2 \n" +
                "Protunapad(Papir) = 3 \n");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out heroPick))
                {
                    if (heroPick == 1 || heroPick == 2 || heroPick == 3)
                        inputStatus = true;
                    else
                    {
                        Console.WriteLine("Krivi unos");
                        inputStatus = false;
                    }
                    heroPick = int.Parse(userInput);
                }
                else
                {
                    Console.WriteLine("Krivi unos");
                }
            } while ((int.TryParse(userInput, out heroPick) == false) || inputStatus == false);
            return heroPick;
        }
    }
}
