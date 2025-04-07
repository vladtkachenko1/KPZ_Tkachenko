using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMetрod
{
    public abstract class Subscription
    {
        public abstract decimal MonthlyFee { get; }
        public abstract int MinPeriodMonths { get; }
        public abstract List<string> Channels { get; }
        public abstract List<string> Features { get; }

        public void ShowInfo()
        {
            Console.WriteLine($"Тип підписки: {GetType().Name}");
            Console.WriteLine($"Місячна плата: {MonthlyFee:C}");
            Console.WriteLine($"Мінімальний період: {MinPeriodMonths} місяців");
            Console.WriteLine("Канали: " + string.Join(", ", Channels));
            Console.WriteLine("Можливості: " + string.Join(", ", Features));
            Console.WriteLine();
        }
    }

}
