using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Наслідувані класи (O - Open/Closed)
    class Mammal : Animal
    {
        public Mammal(string name, string species, string diet) : base(name, species, diet) { }
        public override void MakeSound() => Console.WriteLine($"{Name} видає звук ссавця.");
    }
}