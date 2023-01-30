using System;
namespace RPGStalker
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public double Damage { get; private set; }
        public double Hp { get; set; }
        // Добавить оружие или броню с модификаторами:
        // CRIT - каждый 3 удар увеличивает урон на 150%
        // COLD - каждый 5 удар замораживает противника и он пропускает ход
        // POSION - каждый ход наносится дополнительно 10 урона
        // Модификаторы могут меняться в зависимости от вашей фантазии 

        public Hero(string name, int level, double hp)
        {
            Name = name;
            Level = level;
            Hp = hp;
            Damage = 1.1 * Level;
        }
    }
}

