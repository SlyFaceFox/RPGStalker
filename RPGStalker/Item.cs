using System;
namespace RPGStalker
{
    //Класс отвечающий за вещь в рюкзаке
    public class Item
    {
        public string Name { get; set; }
        public int Weigth { get; set; }
        public int Price { get; set; } 



        public Item(string name, int weigth, int price)
        {
            Name = name;
            Weigth = weigth;
            Price = price;
        }
    }
}
