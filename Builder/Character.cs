using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string Name;
        public double Height;
        public string BodyType;
        public string HairColor;
        public string EyeColor;
        public string Clothes;
        public List<string> Inventory = new();
        public string Alignment;
        public List<string> Actions = new();

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Alignment: {Alignment}");
            Console.WriteLine($"Height: {Height}m");
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothes: {Clothes}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
            if (Actions.Any())
                Console.WriteLine("Actions: " + string.Join(", ", Actions));
            Console.WriteLine();
        }
    }
}
