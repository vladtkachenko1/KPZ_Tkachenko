using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public override decimal MonthlyFee => 19.99m;
        public override int MinPeriodMonths => 1;
        public override List<string> Channels => new List<string> { "Фільми", "Спорт", "Документальні", "Музика", "Ексклюзивні" };
        public override List<string> Features => new List<string> { "HD + 4K", "Багатомовність", "Офлайн-перегляд", "Пріоритетна підтримка" };
    }
}
