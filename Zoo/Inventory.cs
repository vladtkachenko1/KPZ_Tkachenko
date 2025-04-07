using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Клас інвентаризації (S - Single Responsibility)
    class Inventory
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<ZooWorker> Workers { get; set; } = new List<ZooWorker>();

        public void DisplayInfo()
        {
            Console.WriteLine("\n--- Інвентаризація зоопарку ---");
            Console.WriteLine("Тварини:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.Species}) - {animal.Diet}");
            }
            Console.WriteLine("\nСпівробітники:");
            foreach (var worker in Workers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Role}");
            }
        }
    }
}