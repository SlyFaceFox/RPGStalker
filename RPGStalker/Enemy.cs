using System;
namespace RPGStalker
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double Hp { get; set; }
        public double Damage { get; set; }

        // Добавить оружие или броню с модификаторами:
        // CRIT - каждый 3 удар увеличивает урон на 150%
        // COLD - каждый 5 удар замораживает противника и он пропускает ход
        // POSION - каждый ход наносится дополнительно 10 урона
        // Модификаторы могут меняться в зависимости от вашей фантазии

        public Enemy(string name, int level, int hp, double damage)
        {
            Name = name;
            Damage = damage + 1.5 * level;
            Level = level;
            Hp = hp + Level * 1.5;
            
           
        }
    }
}
