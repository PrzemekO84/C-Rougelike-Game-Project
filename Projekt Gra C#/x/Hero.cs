using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Hero
    {
        public int health;
        public int MinAttackPower;
        public int MaxAttackPower;
        public int potions;
        public int special_attack;
        public int gold;




        public Hero(int health, int MinAttackPower, int MaxAttackPower, int potions, int special_attack = 0, int gold = 0)
        {
            this.health = health;
            this.MinAttackPower = MinAttackPower;
            this.MaxAttackPower = MaxAttackPower;
            this.potions = potions;
            this.special_attack = special_attack;
            this.gold = gold;
        }

        public int Attack()
        {
            Console.WriteLine("");
            Console.WriteLine("You are using your basic attack!");
            int damage;
            damage = Random(MinAttackPower, MaxAttackPower);
            if (damage == MaxAttackPower)
            {
                Console.WriteLine("Critical Hit!");
            }
            return damage;
        }


        public static int Random(int min, int max)
        {
            int random_damage;
            Random random = new Random();
            random_damage = random.Next(min, max + 1);
            return random_damage;
        }

        public int Healing(int min, int max, int max_health)
        {

            int heal = Random(min, max);
            if (heal == MaxAttackPower)
            {
                Console.WriteLine("Critical Healing!");
            }
            Console.WriteLine($"Your character heals for {heal} health points!");
            potions -= 1;


            if (health + heal > max_health)
            {
                health = max_health;
                return 0;
            }
            else
            {
                health += heal;
                return heal;
            }





        }
        public int Gold()
        {
            //int percent = 30;
            int random_gold_gain = Random(90, 120);
            return random_gold_gain;
        }
    }

    public class Hero_Knight : Hero
    {
        public Hero_Knight(int health = 30, int MinAttackPower = 5, int MaxAttackPower = 7, int potions = 3, int special_attack = 1, int gold = 0)
            : base(health, MinAttackPower, MaxAttackPower, potions, special_attack, gold)
        {
            //tutaj pusto brak dodatkowych rzeczy
        }

        public int SpecialAttack()
        {

            int special_attack_damage = 10;
            Console.WriteLine("You are using your special attack Justice!");
            Console.WriteLine($"You dealt {special_attack_damage} the to enemy!");

            special_attack = 0;

            return special_attack_damage;
        }

        public void AfterFightHealing()
        {
            int after_fight_healing = Random(3, 5);
            if (health < 30)
            {
                Console.WriteLine("Your character manages to get little rest after the fight.");
                Console.WriteLine($"Your characters heals for {after_fight_healing} health points.");

                if (health + after_fight_healing > 30)
                {
                    health = 30;

                }
                else
                {
                    health = health + after_fight_healing;
                }
            }
            Console.WriteLine("");
        }

        public static Hero_Knight CreateKnight()
        {
            
            return new Hero_Knight(30, 5, 8, 3, 1);
        }

    }


    public class Hero_Rogue : Hero
    {
        public Hero_Rogue(int health = 24, int MinAttackPower = 6, int MaxAttackPower = 8, int potions = 3, int special_attack = 1, int gold = 0)
            : base(health, MinAttackPower, MaxAttackPower, potions, special_attack, gold)
        {
            //tutaj pusto brak dodatkowych rzeczy
        }

        public int SpecialAttack()
        {

            int special_attack_damage = 13;
            Console.WriteLine("You are using your special attack Assasination!");
            Console.WriteLine($"You dealt {special_attack_damage} to the enemy!");

            special_attack = 0;
            return special_attack_damage;
        }

        public void AfterFightHealing()
        {
            int after_fight_healing = Random(2, 4);
            if (health < 24)
            {
                Console.WriteLine("Your character manages to get little rest before next fight");
                Console.WriteLine($"Your characters heals for {after_fight_healing}");

                if (health + after_fight_healing > 24)
                {
                    health = 24;

                }
                else
                {
                    health = health + after_fight_healing;
                }
            }
            Console.WriteLine("");

        }

        public static Hero_Rogue CreateRogue()
        {

            return new Hero_Rogue(24, 7, 9, 3, 1);
        }
    }


    public class Hero_Sorcerer
    {
        int health;
    }
}

    //public class Corrupted_Shadows_1 : Hero
    //{
    //    public Corrupted_Shadows_1(int health, int MinAttackPower, int MaxAttackPower, int potions)
    //        : base(health, MinAttackPower, MaxAttackPower, potions)
    //    {

//    }

//    public static Corrupted_Shadows_1 Create_Shadow_1()
//    {
//        return new Corrupted_Shadows_1(15, 4, 6, 2);
//    }

//    public void Shadow_1_Healing()
//    {
//        if (health >= 10)
//        {
//            Console.WriteLine("Corrupted Shadow He");
//        }
//    }

//}
