using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
        }

        public Virus Clone()
        {
            var clonedVirus = new Virus(Name, Species, Weight, Age);
            foreach (var child in Children)
            {
                clonedVirus.Children.Add(child.Clone());
            }
            return clonedVirus;
        }

        public void Print(int indent = 0)
        {
            string prefix = new string(' ', indent);
            Console.WriteLine($"{prefix}Virus Name: {Name}");
            Console.WriteLine($"{prefix}  Species: {Species}");
            Console.WriteLine($"{prefix}  Age: {Age}");
            Console.WriteLine($"{prefix}  Weight: {Weight}g");
            Console.WriteLine($"{prefix}  Children: {Children.Count}");
            Console.WriteLine();

            foreach (var child in Children)
            {
                child.Print(indent + 4);
            }
        }

    }
}
