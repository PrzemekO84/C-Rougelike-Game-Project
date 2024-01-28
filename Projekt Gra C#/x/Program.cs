using System;
using System.Data;
using System.Reflection;


namespace game
{
    class Program
    {
        private static int restart_point = 0;
        static void Main(string[] args)
        {
            bool game = true;
            GameStart();
            while (game)
            {
                Game_Menu(ref game);
            }



            Console.ReadLine();
        }
        static void Game_Menu(ref bool game)
        {
            Console.WriteLine();
            Console.WriteLine("Game menu:");
            Console.WriteLine("");
            Console.WriteLine("1.Game start");
            Console.WriteLine("2.Heroes informations and rules");
            Console.WriteLine("3.Quit game");
            int menu_option;

            if (int.TryParse(Console.ReadLine(), out menu_option))
            {
                switch (menu_option)
                {
                    case 1:
                        Game();
                        break;
                    case 2:
                        Heroes_Rules.Menu();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Thanks for playing!");
                        game = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        Continue();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number");
            }

        }

        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("You finally arrived to the Shire.");
            Console.WriteLine("It's your time to prove yourself and help all residents of this city.");
            Console.WriteLine("Will you be the one to prove worthy?");
            Console.WriteLine("But before that you need to choose your equipment.");
            Console.WriteLine("");
            Continue();

            Hero selectedHero = Choosing_class();

            Corrupted_Shadow_1 corrupted_Shadow_1 = new Corrupted_Shadow_1(12, 12, 3, 5, 2, 3, 5);
            Corrupted_Shadow_1 corrupted_Shadow_2 = new Corrupted_Shadow_1(13, 13, 4, 6, 2, 4, 5);
            Boss_1 shadow_warrior = new Boss_1(14, 14, 5, 7, 3, 5, 7);
            Master_of_Shadows master_of_shadows_1 = new Master_of_Shadows(14, 14, 5, 6, 2, 4, 6);
            Master_of_Shadows master_of_shadows_2 = new Master_of_Shadows(15, 15, 5, 7, 3, 4, 7);
            Boss_2 King_of_the_shadows = new Boss_2(18, 18, 6, 7, 5, 5, 8);
            bool game = true;
            
            Console.WriteLine("You leave the old Forge and head staright into the forest.");
            Console.WriteLine("You step into the abyss of fear.");
            Console.WriteLine("After only one minute your mind and thoughts starts to become darker than ever before.");
            Console.WriteLine("Is that how forest attacks people?");
            Console.WriteLine("But you cannot turn back, not now.");
            Console.WriteLine();
            Continue();
            //Console.Clear();

            while (game)
            {
                Console.WriteLine("As you move further into the forest you see weird shadow of a tree that immediately walks towards you and try to attack you!");
                Console.WriteLine("It's your time to defend yourself!");
                Combat(selectedHero, corrupted_Shadow_1);
                
                //Console.Clear();
                //Console.SetCursorPosition(0, 0);
                //Continue();
                if (selectedHero.health == 0)
                {                    

                    Console.WriteLine("");
                    Console.WriteLine("Maybe you wasn't the chosen one after all?");
                    Console.WriteLine("");
                    Continue();
                    break;
                }
                //Console.Clear();
                Console.WriteLine("In a distance you see another unnatural shadow, fortunately this time you are prepared. ");
                Console.WriteLine("Prepare yourself!");
                Combat(selectedHero, corrupted_Shadow_2);
                if (selectedHero.health == 0)
                {
;
                    Console.WriteLine("");
                    Console.WriteLine("Maybe you wasn't the chosen one after all?");
                    Console.WriteLine("");
                    Continue();
                    break;
                }
                Shop_First_Encounter_1();
                Display_Shop(selectedHero);
                Console.WriteLine("You get to the river in a middle of a forest, you know you are getting closer.");
                Console.WriteLine("There is only a wooden bridge to cross to get on the other side.");
                Console.WriteLine("Wait.. is that a shadow in a human form on that bridge?");
                Console.WriteLine("Boss Fight!");
                Combat(selectedHero, shadow_warrior);
                if (selectedHero.health == 0)
                {

                    Console.WriteLine("");
                    Console.WriteLine("This creature did his best in not letting you go through");
                    Console.WriteLine("");
                    Continue();
                    break;
                }
                Console.WriteLine("As you hit your opponent with a final attack, the only thing you can see is his armor falling into the river.");
                Console.WriteLine("After getting on the other side of the river you catch sight of person that might be responsible for all these shadow creatures.");
                Combat(selectedHero, master_of_shadows_1);
                if (selectedHero.health == 0)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Those sorcerers are not a joke.");
                    Console.WriteLine("");
                    Continue();
                    break;
                }
                Shop_Second_Encounter_2();
                Display_Shop(selectedHero);
                Console.WriteLine("As you get closer and closer to the heart of a forest, thinking that you are almost there another Master of shadows attacks you.");
                Console.WriteLine("You are so close you cannot give up right now!");
                Combat(selectedHero, master_of_shadows_2);
                if (selectedHero.health == 0)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Those sorcerers are not a joke.");
                    Console.WriteLine("");
                    Continue();
                    break;
                }                
                Console.WriteLine("You did it, you finally arrived to the heart of the forest");
                Console.WriteLine("You can fulfill your desitny.");
                Console.WriteLine("You see him. It's certainly him. King of all the evilness that exists in this forest.");
                Console.WriteLine("There is only one more thing to do.");
                Combat(selectedHero, King_of_the_shadows);
                if (selectedHero.health == 0)
                {

                    Console.WriteLine("");
                    Console.WriteLine("You were so close...");
                    Console.WriteLine("");
                    Continue();
                    break;
                }
                Console.WriteLine("You did you defated the King of the shadows you saved all the people from the city!");
                Console.WriteLine("Congratulations!");
                Continue();
                Console.WriteLine("Thanks for playing! Want to try with a different class?");
                Console.WriteLine();
                break;
            }

        }

        public static void Combat(Hero selectedHero, Enemy enemy)
        {
            Console.WriteLine("");
            Console.WriteLine("Fight!");
            while (true)
            {
                //Console.WriteLine();
                //Continue();
                stats(selectedHero, enemy);
                Console.WriteLine("");
                Player_combat(selectedHero, enemy);
                if (enemy.health == 0)
                {
                    Continue();
                    Console.Clear();
                    break;
                }
                Enemy_Combat(selectedHero, enemy);
                if (selectedHero.health == 0)
                {
                    break;
                }
                Console.WriteLine();
                Continue();
            }
            
        }
        public static void stats(Hero selectedHero, Enemy enemy)
        {
            Console.WriteLine("");
            Console.WriteLine($"Health Points: {selectedHero.health}");
            Console.WriteLine($"Potions: {selectedHero.potions}");
            Console.WriteLine($"Gold: {selectedHero.gold}");
            Console.WriteLine($"Special attacks: {selectedHero.special_attack}");

            Console.WriteLine("");

            Console.WriteLine($"Enemy Health: {enemy.health}");
            Console.WriteLine($"Enemy Potions: {enemy.potions}");
            


        }
        public static void Player_combat(Hero selectedHero, Enemy enemy)
        {
            
            while (true)
            {
                InputHandler inputHandler = new InputHandler();
                
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Special Attack");
                //int combat_option = Convert.ToInt32(Console.ReadLine());
                //bool canContinue = true;

                inputHandler.ReadInput();

                if (selectedHero is Hero_Knight knight)
                {
                    if (inputHandler.IsKeyPressed(ConsoleKey.D1))
                    {

                        //int win;
                        int attack_hero = selectedHero.Attack();
                        Console.WriteLine("");
                        Console.WriteLine($"You dealt {attack_hero} damage to the enemy!");
                        enemy.health = Math.Max(0, enemy.health - attack_hero);


                        if (enemy.health == 0)
                        {
                            int gold = selectedHero.Gold();
                            selectedHero.gold += gold;
                            Console.WriteLine("");
                            Console.WriteLine("Vicotry!");
                            Console.WriteLine("");
                            if (!(enemy is Boss_2))
                            {
                                knight.AfterFightHealing();
                            }


                            if (selectedHero.special_attack == 0 && restart_point < 1)
                            {
                                restart_point += 1;

                            }
                            else
                            {
                                selectedHero.special_attack = 1;
                                restart_point = 0;

                            }

                        }
                        break;
                    }
                    else if (inputHandler.IsKeyPressed(ConsoleKey.D2))
                    {
                        if (knight.health == 30)
                        {
                            Console.WriteLine("Cannot heal! Health is already full!");
                            Continue();
                            stats(selectedHero, enemy);
                            Console.WriteLine();
                            continue;
                        }
                        else if (selectedHero.potions <= 0)
                        {
                            Console.WriteLine("You don't have any healing potions!");
                            Continue();
                            stats(selectedHero, enemy);
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine();
                            knight.Healing(5, 7, 30);
                            break;
                        }
                    }
                    else if (inputHandler.IsKeyPressed(ConsoleKey.D3))
                    {
                        if (selectedHero.special_attack == 0)
                        {
                            int round_count = (2 - restart_point);
                            Console.WriteLine("");
                            Console.WriteLine("You cannot use special attack!");
                            Console.WriteLine($"You need to wait {round_count} rounds before using your special attack");
                            Console.WriteLine("");
                            Continue();
                            stats(selectedHero, enemy);
                            Console.WriteLine();
                            continue;
                        }

                        int special_attack_dmg = knight.SpecialAttack();                        
                        enemy.health = Math.Max(0, enemy.health - special_attack_dmg);
                        

                        if (enemy.health == 0)
                        {
                            int gold = selectedHero.Gold();
                            selectedHero.gold += gold;
                            Console.WriteLine("");
                            Console.WriteLine("Vicotry!");
                            Console.WriteLine("");
                            if (!(enemy is Boss_2))
                            {
                                knight.AfterFightHealing();
                            }
                            

                            if (selectedHero.special_attack == 0 && restart_point < 1)
                            {
                                restart_point += 1;

                            }
                            else
                            {
                                selectedHero.special_attack = 1;
                            }

                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please press 1, 2, or 3.");
                        Continue();
                        stats(selectedHero, enemy);
                        Console.WriteLine();
                        continue;
                    }
                }
                else if (selectedHero is Hero_Rogue rogue)
                {
                    if (inputHandler.IsKeyPressed(ConsoleKey.D1))
                    {

                        //int win;
                        int attack_hero = selectedHero.Attack();
                        Console.WriteLine($"You dealt {attack_hero} damage to the enemy!");
                        enemy.health = Math.Max(0, enemy.health - attack_hero);


                        if (enemy.health == 0)
                        {
                            int gold = selectedHero.Gold();
                            selectedHero.gold += gold;
                            Console.WriteLine("");
                            Console.WriteLine("Vicotry!");
                            Console.WriteLine("");
                            if (!(enemy is Boss_2))
                            {
                                rogue.AfterFightHealing();
                            }
                            

                            if (selectedHero.special_attack == 0 && restart_point < 2)
                            {
                                restart_point += 1;
                                Console.WriteLine(restart_point);

                            }
                            else
                            {
                                selectedHero.special_attack = 1;
                                restart_point = 0;

                            }

                        }
                        break;
                    }
                    else if (inputHandler.IsKeyPressed(ConsoleKey.D2))
                    {
                        if (rogue.health == 24)
                        {
                            Console.WriteLine("Cannot heal! Health is already full!");
                            Continue();
                            stats(selectedHero, enemy);
                            Console.WriteLine();
                            continue;
                        }
                        else if (selectedHero.potions <= 0)
                        {
                            Console.WriteLine("You don't have any healing potions!");
                            Continue();
                            stats(selectedHero, enemy);
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            rogue.Healing(5, 8, 24);
                            break;
                        }
                    }
                    else if (inputHandler.IsKeyPressed(ConsoleKey.D3))
                    {
                        if (selectedHero.special_attack == 0)
                        {
                            int round_count = (3 - restart_point);
                            Console.WriteLine("");
                            Console.WriteLine("You cannot use special attack!");
                            Console.WriteLine($"You need to wait {round_count} rounds before using your special attack");
                            Console.WriteLine("");
                            Continue();
                            stats(selectedHero, enemy);
                            Console.WriteLine();
                            continue;
                        }

                        int special_attack_dmg = rogue.SpecialAttack();
                        enemy.health = Math.Max(0, enemy.health - special_attack_dmg);
                        //selectedHero.special_attack = 0;

                        if (enemy.health == 0)
                        {
                            int gold = selectedHero.Gold();
                            selectedHero.gold += gold;
                            Console.WriteLine("");
                            Console.WriteLine("Vicotry!");
                            Console.WriteLine("");
                            if (!(enemy is Boss_2))
                            {
                                rogue.AfterFightHealing();
                            }
                            


                            if (selectedHero.special_attack == 0 && restart_point < 2)
                            {
                                restart_point += 1;

                            }
                            else
                            {
                                selectedHero.special_attack = 1;
                            }

                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please press 1, 2, or 3.");
                        Continue();
                        stats(selectedHero, enemy);
                        Console.WriteLine();
                        continue;
                    }
                }
            }
        }


        public static void Enemy_Combat(Hero selectedHero, Enemy enemy)
        {
            int enemy_move = enemy.Move();

            //if ( >= healing_point || potions == 0)
            //{
            //    return 1;
            //}

            if (enemy_move == 1)
            {
                int enemy_damage = enemy.Attack();
                selectedHero.health = Math.Max(0, selectedHero.health - enemy_damage);

                if (selectedHero.health == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Defeat!");
                }
            }
            else
            {
                enemy.Healing();
            }
        }

        public static Hero Choosing_class()
        {
            while (true)
            {
                Console.WriteLine("You enter an old forge.");
                Console.WriteLine("In front of you, you see few useful weapons that you could use against all the evil creatures.");
                Console.WriteLine("What will you choose?");
                Console.WriteLine("");
                Console.WriteLine("1. Sword and shield (Knight)");
                Console.WriteLine("2. Bow and dagger (Rogue)");
                Console.WriteLine("3. Magic band and scrools of old runes (Sorcerer) (Soon to be added!)");

                InputHandler PlayerKeyInput = new InputHandler();
                PlayerKeyInput.ReadInput();

                if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D1))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Good old sword and shield!");
                    Hero_Knight knight = new Hero_Knight();
                    Console.WriteLine();
                    Continue();
                    return knight;
                    //return Hero_Knight.CreateKnight();
                }
                else if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D2))
                {
                    Console.WriteLine("");
                    Console.WriteLine("I see you like to be in the shadows!");
                    Hero_Rogue rogue = new Hero_Rogue();
                    Console.WriteLine("");
                    Continue();
                    return rogue;
                    //return Hero_Rogue.CreateRogue();
                }
                else if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D3))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorcerer is not available at the moment.");
                    Console.WriteLine("Please choose diffrent class.");
                    Continue();
                    //continue;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    Continue();
                    //continue;
                }

            }
        }
            

        public static void Shop_First_Encounter_1()
        {
            Console.WriteLine("");
            Console.WriteLine("On your way to the heart of Forest you see a person in black suit and purple face scarf");
            Console.WriteLine("But he doesn't seem to be hostile");
            Console.WriteLine("At one point he walks towards you and offer you his merchandise");
        }

        public static void Display_Shop(Hero selectedHero)
        {
            Console.WriteLine("");
            
            bool shop = true;

            

            while (shop)
            {
                InputHandler PlayerKeyInput = new InputHandler();

                Console.WriteLine("The merchant offers you: ");
                Console.WriteLine("1. Helth potions (50 gold)");
                Console.WriteLine("2. Weapon Enchantment (Bonus Damage +1) (200gold)");
                Console.WriteLine("3. Leave shop");
                Console.WriteLine("");
                Console.WriteLine($"Your gold: {selectedHero.gold}");
                Console.WriteLine($"Your potions: {selectedHero.potions}");
                Console.WriteLine();

                PlayerKeyInput.ReadInput();


                if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D1))
                {
                    if (selectedHero.gold < 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You don't have enought gold!");
                        Console.WriteLine("");
                        //Console.WriteLine("Continue, please press any key"); //tak by bylo osobiscie lepiej ale maja byc 3 przyciski B ))
                        
                        Continue();
                    }
                    else
                    {
                        Console.WriteLine("You bought health potion");
                        selectedHero.potions += 1;
                        selectedHero.gold = selectedHero.gold - 50;
                        Console.WriteLine(selectedHero.gold);
                       
                        Continue();                       
                    }
                }
                else if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D2))
                {
                    if (selectedHero.gold < 200)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You don't have enought gold!");
                        Console.WriteLine("");
                        //Console.WriteLine("Continue, please press any key"); //tak by bylo osobiscie lepiej ale maja byc 3 przyciski B ))

                        Continue();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You bought Damage upgrade!");
                        Console.WriteLine("Your attacks will have +1 Damage!");
                        selectedHero.gold = selectedHero.gold - 200;
                        selectedHero.MinAttackPower += 1;
                        selectedHero.MaxAttackPower += 1;
                        
                        Console.WriteLine("");

                        Continue();
                    }
                    

                }
                else if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D3))
                {
                    Console.WriteLine("Are you sure you wanna leave shop ? ");
                    Console.WriteLine("");
                    Console.WriteLine("1. Leave \n" +
                                      "2. Stay");

                    PlayerKeyInput.ReadInput();
                    if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D1))
                    {
                        Console.Clear();
                        break;
                    }
                    else if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D2))
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input please press 1 or 2");

                    }
                }
                else
                {
                    Continue();
                }

            }
        }

        public static void Shop_Second_Encounter_2()
        {
            Console.WriteLine("After a hard fight with Master of shadows you are extremely exhausted");
            Console.WriteLine("Luckly you see a friendly face behind one of the trees");
        }

        public static void Continue()
        {
            InputHandler PlayerKeyInput = new InputHandler();
            Console.WriteLine("Please press 1,2 or 3 to continue");
            while (true)
            {
                PlayerKeyInput.ReadInput();
                if (PlayerKeyInput.IsKeyPressed(ConsoleKey.D1)
                   || PlayerKeyInput.IsKeyPressed(ConsoleKey.D2)
                   || PlayerKeyInput.IsKeyPressed(ConsoleKey.D3))
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    break;
                }
                else
                {

                    continue;
                }

            }
        }

        public class InputHandler
        {
            private ConsoleKeyInfo keyInfo;

            public void ReadInput()
            {
                keyInfo = Console.ReadKey(intercept: true);
            }

            public bool IsKeyPressed(ConsoleKey key)
            {
                return keyInfo.Key == key;
            }
        }

        static void CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;

            int leftMargin = (screenWidth - stringWidth) / 2;

            Console.WriteLine(new string(' ', leftMargin) + text);
        }
        static void GameStart()
        {
            string title = "BLACK FOREST";
            CenterText("Our city is attacked by terrifying creatures from a forest.");
            Thread.Sleep(4000);
            CenterText("");
            CenterText("We are losing many supplies and people.");
            CenterText("We don't stand a chance without help.");
            CenterText("");
            Thread.Sleep(4000);
            CenterText("Are you the chosen hero to save us all?");
            CenterText("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Thread.Sleep(3000);
            CenterText(title);
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}


















