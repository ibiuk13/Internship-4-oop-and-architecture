using System;

namespace Internship_4_oop_and_architecture
{
    class Program
    {
        static void UserChosingValues (string userName)
        {
            Console.WriteLine("Izaberite klasu heroja \nWarrior = 0  \nMage = 1 \nRanger = 2 \n ");
            var heroType = int.Parse(Console.ReadLine());
            switch (heroType)
            {
                case 0:
                    {
                        Console.WriteLine("Unesite HP svog heroja");
                        var userHealth = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite Damage svog heroja");
                        var userDamage = int.Parse(Console.ReadLine());
                        var userHero = new Warrior
                        {
                            Name = userName,
                            HealthPoints = userHealth,
                            Experience = 0,
                            Damage = userDamage,
                            HeroType = HeroTypeEnum.Warrior
                        };
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Unesite HP svog heroja");
                        var userHealth = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite Damage svog heroja");
                        var userDamage = int.Parse(Console.ReadLine());
                        var userHero = new Mage
                        {
                            Name = userName,
                            HealthPoints = userHealth,
                            Experience = 0,
                            Mana = 100,
                            Damage = userDamage,
                            HeroType = HeroTypeEnum.Mage
                        };
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Unesite HP svog heroja");
                        var userHealth = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite Damage svog heroja");
                        var userDamage = int.Parse(Console.ReadLine());
                        var userHero = new Ranger
                        {
                            Name = userName,
                            HealthPoints = userHealth,
                            Experience = 0,
                            Damage = userDamage,
                            HeroType = HeroTypeEnum.Ranger
                        };
                    }
                    break;
            }

        }
        static void ComputerChosingValues (string userName)
        {
            Console.WriteLine("Izaberite klasu heroja \nWarrior = 0  \nMage = 1 \nRanger = 2 \n ");
            var heroType = int.Parse(Console.ReadLine());
            switch (heroType)
            {
                case 0:
                    {
                        var userHero = new Warrior
                        {
                            Name = userName,
                            HealthPoints = 100,
                            Experience = 0,
                            Damage = 25,
                            HeroType = HeroTypeEnum.Warrior
                        };
                    }
                    break;
                case 1:
                    {
                        var userHero = new Mage
                        {
                            Name = userName,
                            HealthPoints = 50,
                            Experience = 0,
                            Mana = 100,
                            Damage = 75,
                            HeroType = HeroTypeEnum.Mage
                        };
                    }
                    break;
                case 2:
                    {
                        var userHero = new Ranger
                        {
                            Name = userName,
                            HealthPoints = 75,
                            Experience = 0,
                            Damage = 50,
                            HeroType = HeroTypeEnum.Ranger
                        };
                    }
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Stvorite svog heroja");
            Console.WriteLine("Unesite ime heroja");
            var userName = Console.ReadLine();
            var pick = new int();
            do
            {
                do
                {
                    Console.WriteLine("Želite li sami odrediti njegove HP i Damage?");
                    Console.WriteLine("1-DA   0-NE");
                    if (int.TryParse(Console.ReadLine(), out pick))
                        pick = int.Parse(Console.ReadLine());
                    else
                    {
                        Console.WriteLine("Krivi unos");
                        Console.WriteLine("Želite li sami odrediti njegove HP i Damage?");
                        Console.WriteLine("1-DA   0-NE");
                    }
                } while (int.TryParse(Console.ReadLine(), out pick) == false);
                if (pick == 1)
                {
                    UserChosingValues(userName);
                }
                else if (pick == 0)
                {
                    ComputerChosingValues(userName);
                }
                else Console.WriteLine("Krivi unos");
            } while ((pick != 0) && (pick != 1));
            

        }
    }
}
