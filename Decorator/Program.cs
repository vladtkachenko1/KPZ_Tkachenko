using Decorator.InventoryDecorator;
using Decorator;
using System;

class Program
{
    static void Main(string[] args)
    {
        IHero warrior = new Warrior();
        warrior = new Sword(warrior);
        warrior = new Armor(warrior);
        warrior = new Amulet(warrior);

        Console.WriteLine(warrior.GetDescription()); // Воїн з мечем в броні з амулетом
        Console.WriteLine("Сила: " + warrior.GetPower()); // 10 + 5 + 3 + 2 = 20

        Console.WriteLine();

        IHero mage = new Mage();
        mage = new Amulet(mage);
        mage = new Amulet(mage); // Два амулети

        Console.WriteLine(mage.GetDescription()); 
        Console.WriteLine("Сила: " + mage.GetPower()); // 8 + 2 + 2 = 12
    }
}
