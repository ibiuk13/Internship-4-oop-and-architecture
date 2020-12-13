using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_4_oop_and_architecture_Game
{
    public class CreatingHero
    {
        public static Hero UserCreatingHero(Hero userHero)
        {

            Console.WriteLine("Stvorite svog heroja");
            Console.WriteLine("Unesite ime heroja");
            var userName = Console.ReadLine();
            var pick = new int();
            string userType;
            do
            {
                Console.WriteLine("Izaberite klasu heroja \nWarrior = 0  \nMage = 1 \nRanger = 2 \n ");
                userType = Console.ReadLine();
                if (int.TryParse(userType, out pick))
                {
                    pick = int.Parse(userType);
                    if (pick != 0 && pick != 1 && pick != 2) Console.WriteLine("Krivi unos");
                }
                else
                    Console.WriteLine("Krivi unos");
            } while (int.TryParse(userType, out pick) == false && pick != 0 && pick != 1 && pick != 2);

            Console.WriteLine("Želite li sami odrediti njegove HP i Damage?");
            Console.WriteLine("1-DA   0-NE");
            
            var userChoice = int.Parse(Console.ReadLine());
            switch (pick)
            {
                case 0:
                    {
                        switch (userChoice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Unesite HP");
                                    var userHealthPoints = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Unesite Damage");
                                    var userDamage = double.Parse(Console.ReadLine());
                                    userHero = (Warrior)Warrior.CreateWarrior(userName, userHealthPoints, 0, userDamage);
                                    return (Warrior)userHero;

                                }
                            case 0:
                                {
                                    userHero = (Warrior)Warrior.CreateWarrior(userName, 100, 0, 25);
                                    return (Warrior)userHero;

                                }
                        }
                        break;
                    }
                case 1:
                    {
                        switch (userChoice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Unesite HP");
                                    var userHealthPoints = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Unesite Damage");
                                    var userDamage = double.Parse(Console.ReadLine());
                                    userHero = (Mage)Mage.CreateMage(userName, userHealthPoints, 0, userDamage, 100);
                                    return (Mage)userHero;

                                }
                            case 0:
                                {
                                    userHero = (Mage)Mage.CreateMage(userName, 100, 0, 25, 100);
                                    return (Mage) userHero;
                                }
                        }
                        break;

                    }
                case 2:
                    {
                        switch (userChoice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Unesite HP");
                                    var userHealthPoints = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Unesite Damage");
                                    var userDamage = double.Parse(Console.ReadLine());
                                    userHero = (Ranger)Ranger.CreateRanger(userName, userHealthPoints, 0, userDamage, 100);
                                    return (Ranger)userHero;

                                }
                            case 0:
                                {
                                    userHero = (Ranger)Ranger.CreateRanger(userName, 100, 0, 25, 100);
                                    return (Ranger)userHero;

                                }
                        }
                        break;

                    }
            }
            return userHero;
        }
    }
}
