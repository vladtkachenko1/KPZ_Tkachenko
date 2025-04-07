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

            EnclosureBase lionEnclosure = new MammalEnclosure(2);
            EnclosureBase parrotEnclosure = new BirdEnclosure(2);

            lionEnclosure.AddAnimal(lion);
            parrotEnclosure.AddAnimal(parrot);

            ZooWorker worker1 = new ZooWorker("Олексій", "Доглядач");
            ZooWorker worker2 = new ZooWorker("Марина", "Ветеринар");

            Inventory inventory = new Inventory();
            inventory.Animals.AddRange(lionEnclosure.Animals);
            inventory.Animals.AddRange(parrotEnclosure.Animals);
            inventory.Workers.Add(worker1);
            inventory.Workers.Add(worker2);

            lionEnclosure.DisplayDetails();
            parrotEnclosure.DisplayDetails();

            inventory.DisplayInfo();
        }
    }
}
