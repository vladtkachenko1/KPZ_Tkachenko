using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Bird : Animal
    {
        public Bird(string name, string species, string diet) : base(name, species, diet) { }
        public override void MakeSound() => Console.WriteLine($"{Name} щебече.");
    }
}