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

        public void ShowInfo()
        {
            Console.WriteLine($"Subscription: {GetType().Name}");
            Console.WriteLine($"Monthly Fee: {MonthlyFee:C}");
            Console.WriteLine($"Min Period: {MinPeriodMonths} months");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine();
        }
    }

}
