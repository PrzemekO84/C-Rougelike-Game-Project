using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Enemy
    {
        public int health;
        public int max_health;
        public int MinAttackPower;
        public int MaxAttackPower;
        public int potions;
        public int MinHeal;
        public int MaxHeal;
        public int special_attack;
        public Enemy(int health, int max_health, int MinAttackPower, int MaxAttackPower, int potions, int MinHeal, int MaxHeal, int special_attack)
        {
            this.health = health;
            this.max_health = max_health;
            this.MinAttackPower = MinAttackPower;
            this.MaxAttackPower = MaxAttackPower;
            this.potions = potions;
            this.MinHeal = MinHeal;
            this.MaxHeal = MaxHeal;
            this.special_attack = special_attack;
        }

        public static int Random(int min, int max)
        {
            int random_damage;
            Random random = new Random();
            random_damage = random.Next(min, max + 1);
            return random_damage;
        }

        public int Attack()
        {
            int damage;
            damage = Random(MinAttackPower, MaxAttackPower);
            Console.WriteLine("");
            Console.WriteLine("Enemy Attacking!");
            Console.WriteLine("");
            Console.WriteLine($"Enemy attacks for {damage} health points!");
            if (damage == MaxAttackPower)
            {
                Console.WriteLine("Critical Hit!");
            }
            return damage;
        }

        public int Healing()
        {
            int heal = Random(MinHeal, MaxHeal);
            
            if (health + heal > max_health)
            {
                health = max_health;

            }
            else
            {
                health = health + heal;
            }
            Console.WriteLine("Enemy Heals!");
            Console.WriteLine("");
            Console.WriteLine($"Enemy heals for {heal} health points");
            potions -= 1;
            return heal;
        }

        public int Move()
        {
            //int move;
            Random random = new Random();
            int random_move = random.Next(1, 3);

            int healing_point = (max_health - 5);


            if (health >= healing_point || potions == 0)
            {
                return 1;
            }
            else if (random_move == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }

    //public class MoveResult
    //{
    //    public int Damage { get; set; }
    //    public bool IsAttack { get; set; }
    //}
    public class Corrupted_Shadow_1 : Enemy
    {
        public Corrupted_Shadow_1(int health, int max_health, int MinAttackPower, int MaxAttackPower, int potions, int MinHeal, int MaxHeal, int special_attack = 0)
            : base(health, max_health, MinAttackPower, MaxAttackPower, potions, MinHeal, MaxHeal, special_attack)
        {
            //
        }

        public int special_attack()
        {
            return 0;
            //mozliwe ulepszenie przeciwnikow B)
        }

    }

    public class Boss_1 : Enemy
    {
        public Boss_1(int health, int max_health, int MinAttackPower, int MaxAttackPower, int potions, int MinHeal, int MaxHeal, int special_attack = 1)
            : base(health, max_health, MinAttackPower, MaxAttackPower, potions, MinHeal, MaxHeal, special_attack)
        {
            //
        }

        //public static Corrupted_Shadow_1 Create_Shadow_1()
        //{
        //    return new Corrupted_Shadow_1(15, 5, 4, 6, 2, 3, 6);
        //}

        public int special_attack()
        {
            return 0;
            
        }


    }

    public class Master_of_Shadows : Enemy
    {
        public Master_of_Shadows(int health, int max_health, int MinAttackPower, int MaxAttackPower, int potions, int MinHeal, int MaxHeal, int special_attack = 1)
            : base(health, max_health, MinAttackPower, MaxAttackPower, potions, MinHeal, MaxHeal, special_attack)
        {
            //
        }


        public int special_attack()
        {
            return 0;
            
        }


    }

    public class Boss_2 : Enemy
    {
        public Boss_2(int health, int max_health, int MinAttackPower, int MaxAttackPower, int potions, int MinHeal, int MaxHeal, int special_attack = 1)
            : base(health, max_health, MinAttackPower, MaxAttackPower, potions, MinHeal, MaxHeal, special_attack)
        {
            //
        }

        public int special_attack()
        {
            return 0;
            
        }


    }
}
