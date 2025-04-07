using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Клас для вольєрів (S - Single Responsibility)
    class Enclosure
    {
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Enclosure(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
        }

        public void AddAnimal(Animal animal)
        {
            if (Animals.Count < Capacity)
            {
                Animals.Add(animal);
                Console.WriteLine($"{animal.Name} додано у {Type} вольєр.");
            }
            else
            {
                Console.WriteLine($"Вольєр {Type} переповнений!");
            }
        }
    }
}