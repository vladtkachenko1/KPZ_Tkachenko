using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class BirdEnclosure : EnclosureBase
    {
        public BirdEnclosure(int capacity) : base("Пташиний", capacity) { }

        public override void DisplayDetails()
        {
            Console.WriteLine($"\nВольєр: {Type} | Місткість: {Capacity} | Тварин: {Animals.Count}");
            foreach (var animal in Animals)
            {
                Console.WriteLine($" - {animal.Name} ({animal.Species})");
            }
        }
    }
}
