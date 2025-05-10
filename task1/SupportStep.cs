using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    abstract class SupportStep
    {
        public abstract SupportStep? Execute();
        protected string? GetInput() => Console.ReadLine();
        protected void PrintOptions(Dictionary<string, string> options)
        {
            foreach (var kvp in options)
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            Console.Write("Ваш вибір: ");
        }

        protected bool AssignHandler(string handler)
        {
            Console.WriteLine($"\nВас буде з'єднано з: {handler}.");
            return true;
        }
    }

}
