using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Heroes_Rules
    {
        public static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("1.Heroes");
            Console.WriteLine("2.Rules");
            Console.WriteLine("3.Exit");
            int menu_Option;

            if (int.TryParse(Console.ReadLine(), out int menuOption))
            {
                switch (menuOption)
                {
                    case 1:
                        Heroses();
                        break;
                    case 2:
                        Rules();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Menu();
            }
        }
        public static void Heroses()
        {
            Console.WriteLine("");
            Console.WriteLine("1.Knight");
            Console.WriteLine("2.Rogue");
            Console.WriteLine("3.Sorcerer");

            int hero_option;

            if (int.TryParse(Console.ReadLine(), out hero_option))
            {
                switch (hero_option)
                {
                    case 1:
                        string knight = "Class Knight";
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        CenterText(knight);
                        Console.ResetColor();
                        Knight_informations();
                        break;

                    case 2:
                        string Rogue = "Class Rogue";
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        CenterText(Rogue);
                        Console.ResetColor();
                        Rogue_informations();
                        break;
                    case 3:
                        string Sorcerer = "Class Sorcerer (Soon to be added!)";
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        CenterText(Sorcerer);
                        Console.ResetColor();
                        Sorcerer_informations();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        Heroses();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Option. Please enter a number");
                Heroses();
            }

        }
        static void Knight_informations()
        {
            Console.WriteLine("Knight is a solid class with a decent amount of power, health postions and highest health!");
            Console.WriteLine("Health: 30Hp");
            Console.WriteLine("Attack power: 5-7 DMG");
            Console.WriteLine("Postions: 3 Health postions");
            Console.WriteLine("Special Attack: Justice (Once per 2 fights deal 10 DMG with your justice sword");
            Console.WriteLine("Click any key to get back to main menu");

        }
        static void Rogue_informations()
        {
            Console.WriteLine("Rouge is a class with lowest health, average amout of potions and strongest attacks!");
            Console.WriteLine("Health: 24Hp");
            Console.WriteLine("Attack power: 6-8 DMG");
            Console.WriteLine("Postions: 3 Health postions");
            Console.WriteLine("Special Attack: Master of shadows (once per 3 combats assasinate your enemy dealing 13 DMG )");
            Console.WriteLine("Click any key to get back to main menu");
        }
        static void Sorcerer_informations()
        {
            Console.WriteLine("Sorcerer is a class with a average health, lowest attack damage but has 2 special attacks and higest number of healts postions");
            Console.WriteLine("Health: 25Hp");
            Console.WriteLine("Attack power: 3-5 DMG");
            Console.WriteLine("Postions: 5 Health postions");
            Console.WriteLine("Special Attack: Fire Ball (Once per combat fire giant fire ball at your enemy dealing 8-12 DMG)");
            Console.WriteLine("Second Special Attack: Thuner Bolt (once per combat use Thuner Bolt at your enemy dealing 8-11 DMG ");
            Console.WriteLine("Click any key to get back to main menu");
        }
        static void Rules()
        {
            string rules = "Rules";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            CenterText(rules);
            Console.ResetColor();
            Console.WriteLine("You will need to clear the Dark Forest from terrifying creatures to save all residents of city Shire.");
            Console.WriteLine("You will need to win 6 fights with two bosses on your road.");
            Console.WriteLine("At the end of every won fight you will recive bonus gold and some health points.");
            Console.WriteLine("You can spend your gold at shop.");
            Console.WriteLine("The shop will appear twice in a game.");
            Console.WriteLine("Click any key to get back to main menu.");

        }

        static void CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;

            int leftMargin = (screenWidth - stringWidth) / 2;

            Console.WriteLine(new string(' ', leftMargin) + text);
        }



    }
}
