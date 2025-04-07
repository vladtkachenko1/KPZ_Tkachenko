using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public override decimal MonthlyFee => 4.99m;
        public override int MinPeriodMonths => 6;
        public override List<string> Channels => new List<string> { "Наука", "Історія", "Дитячі освітні" };
        public override List<string> Features => new List<string> { "HD-доступ", "Багатомовність", "Підтримка офлайн перегляду" };
    }
}
