using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public override decimal MonthlyFee => 9.99m;
        public override int MinPeriodMonths => 3;
        public override List<string> Channels => new List<string> { "Новини", "Розваги", "Місцевий спорт" };
        public override List<string> Features => new List<string> { "Доступне HD", "Перегляд офлайн недоступний" };
    }
}
