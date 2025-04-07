using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DiscountedSubscription : Subscription
    {
        private readonly Subscription _original;
        private readonly decimal _discount;

        public DiscountedSubscription(Subscription original, decimal discount)
        {
            _original = original;
            _discount = discount;
        }

        public override decimal MonthlyFee => Math.Round(_original.MonthlyFee * (1 - _discount), 2);
        public override int MinPeriodMonths => _original.MinPeriodMonths;
        public override List<string> Channels => _original.Channels;
        public override List<string> Features => new List<string>(_original.Features) { $"Знижка: {_discount * 100}% застосовано" };
    }
}
