using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Mammal lion = new Mammal("Лев", "Panthera leo", "М'ясоїд");
            Bird parrot = new Bird("Папуга", "Ara", "Всеїдний");

            Enclosure largeEnclosure = new Enclosure("Великий", 2);
            largeEnclosure.AddAnimal(lion);
            largeEnclosure.AddAnimal(parrot);

            ZooWorker worker1 = new ZooWorker("Олексій", "Доглядач");
            ZooWorker worker2 = new ZooWorker("Марина", "Ветеринар");

            Inventory inventory = new Inventory();
            inventory.Animals.AddRange(largeEnclosure.Animals);
            inventory.Workers.Add(worker1);
            inventory.Workers.Add(worker2);

            Console.WriteLine($"Кількість тварин у вольєрі: {largeEnclosure.Animals.Count}");

            foreach (var animal in largeEnclosure.Animals)
            {
                animal.MakeSound();
            }

            inventory.DisplayInfo();
        }
    }
}
