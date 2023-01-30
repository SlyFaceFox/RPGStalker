using System;
using System.Runtime.ConstrainedExecution;

namespace RPGStalker
{
    public class BattleArena
    {
        public Enemy Enemy { get; set; }
        public Hero Hero { get; set; }
        public Weapon Weapon { get; set; }
        


        public BattleArena(Enemy enemy, Hero hero, Weapon weapon)
        {
            Enemy = enemy;
            Hero = hero;
            Weapon = weapon;
        }



        public int Battle()
        {
            Random rand = new Random();
            int Chance;
            var Enemy = new Enemy("Кабан", 1, 25, 5);
            start:
            Console.WriteLine("1 - Вступать в бой? 2 - Обойти? 3 - Подождать?");
            int ans = int.Parse(Console.ReadLine());
            if (ans == 1)
            {
                do
                {
                    restart:
                    Console.WriteLine();
                    Console.WriteLine($"Ваше здоровье: {Math.Round(Hero.Hp, 0)}");
                    Console.WriteLine($"Здоровье противника: {Math.Round(Enemy.Hp, 0)}");
                    Chance = rand.Next(0,2);
                    if (Chance == 0)
                    {
                        Console.WriteLine($"Вы нанесли урона противнику: {Math.Round(Hero.Damage + Weapon.Damage, 1)}");
                        Enemy.Hp -= (Hero.Damage + Weapon.Damage);
                        if (Enemy.Hp <= 0)
                        {
                            Console.WriteLine("Вы победили врага!");
                            return 1;
                        }
                    }
                    else if (Chance == 1)
                    {
                        Console.WriteLine($"Вы нанесли критический урон противнику: {Math.Round(1.5*(Hero.Damage + Weapon.Damage), 1)}");
                        Enemy.Hp -= (Hero.Damage + Weapon.Damage);
                        if (Enemy.Hp <= 0)
                        {
                            Console.WriteLine("Вы победили врага!");
                            return 1;
                        }
                    }
                    Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                    Hero.Hp -= Enemy.Damage;
                    if (Hero.Hp <= 0)
                    {
                        Console.WriteLine("Вы погибли...");
                        return 0;
                    }
                    else { goto restart; }
                }
                while (Enemy.Hp > 0 && Hero.Hp > 0);
                
            }
            else if (ans == 2)
            {
                Chance = rand.Next(0, 2);
                if (Chance == 0)
                {
                    Console.WriteLine("Вы обошли противника, и продолжили свой путь.");
                    goto start;
                    
                    
                }
                else if (Chance == 1)
                {
                    Console.WriteLine(Chance);
                    Console.WriteLine("Противник обнаружил Вас. Как вы поступите? 1 - Вступить в бой, 2 - Сбежать");
                    ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        do
                        {
                            restart:
                            Console.WriteLine();
                            Console.WriteLine($"Ваше здоровье: {Math.Round(Hero.Hp, 0)}");
                            Console.WriteLine($"Здоровье противника: {Math.Round(Enemy.Hp, 0)}");
                            Console.WriteLine($"Вы нанесли урона противнику: {Math.Round(Hero.Damage + Weapon.Damage,1)}");
                            Enemy.Hp -= (Hero.Damage + Weapon.Damage);
                            if (Enemy.Hp <= 0)
                            {
                                Console.WriteLine("Вы победили врага!");
                                return 1;
                            }
                            Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                            Hero.Hp -= Enemy.Damage;
                            if (Hero.Hp <= 0)
                            {
                                Console.WriteLine("Вы погибли...");
                                return 0;
                            }
                            else { goto restart; }
                        }
                        while (Enemy.Hp > 0 && Hero.Hp > 0);
                     
                    }
                    else if (ans == 2)
                    {
                        Console.WriteLine("Вы сбежали. Вам крупно повезло.");
                        goto start;
                    }
                    else
                    {
                        goto start;
                    }
                }
                else
                {
                    Console.WriteLine(Chance);
                    goto start;
                }
            }
            else if (ans == 3)
            {
                Chance = rand.Next(0, 2);
                if (Chance == 0)
                {
                    Console.WriteLine("Вы подождали, пока противник не ушлёл по дальше.");
                    goto start;
                }
                else if (Chance == 1)
                {
                    Console.WriteLine("Противник пошёл в вашу сторону и заметил вас");
                    Console.WriteLine("Как вы поступите? 1 - Вступить в бой, 2 - Сбежать");
                    ans = int.Parse(Console.ReadLine());
                    if (ans == 1)
                    {
                        do
                        {
                            restart:
                            Console.WriteLine();
                            Console.WriteLine($"Ваше здоровье: {Math.Round(Hero.Hp, 0)}");
                            Console.WriteLine($"Здоровье противника: {Math.Round(Enemy.Hp, 0)}");
                            Chance = rand.Next(0, 2);
                            if (Chance == 0)
                            {
                                Console.WriteLine($"Вы нанесли урона противнику: {Math.Round(Hero.Damage + Weapon.Damage, 1)}");
                                Enemy.Hp -= (Hero.Damage + Weapon.Damage);
                                if (Enemy.Hp <= 0)
                                {
                                    Console.WriteLine("Вы победили врага!");
                                    return 1;
                                }
                            }
                            else if (Chance == 1)
                            {
                                Console.WriteLine($"Вы нанесли критический урон противнику: {Math.Round(1.5 * (Hero.Damage + Weapon.Damage), 1)}");
                                Enemy.Hp -= (Hero.Damage + Weapon.Damage);
                                if (Enemy.Hp <= 0)
                                {
                                    Console.WriteLine("Вы победили врага!");
                                    return 1;
                                }
                            }

                            Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                            Hero.Hp -= Enemy.Damage;
                            if (Hero.Hp <= 0)
                            {
                                Console.WriteLine("Вы погибли...");
                                return 0;
                            }
                            else { goto restart; }
                        }
                        while (Enemy.Hp > 0 && Hero.Hp > 0);
                    }
                    else if (Chance == 2)
                    {
                        goto start;
                    }
                    else
                    {
                        goto start;
                    }
                    
                }
                else
                {
                    goto start;
                }

            }
            else
            {
                goto start; 
            }
            
        }
        
    }


}
