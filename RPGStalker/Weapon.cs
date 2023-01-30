using System;
using System.Xml.Linq;

namespace RPGStalker
{
    public class Weapon
    {
        Random rand = new Random();
        public string Name { get; set; }
        public int Damage { get; set; }
        public string Мodification { get; set; }


        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;

        }
    }
}





