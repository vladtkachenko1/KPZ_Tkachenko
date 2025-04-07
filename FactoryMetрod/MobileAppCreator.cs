using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MobileAppCreator : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("[Оформлення через мобільний додаток]");
            var subscription = CreateByType(type);
            Console.WriteLine("Бонус: +1 місяць у подарунок за оформлення через додаток!");
            return subscription;
        }

        private Subscription CreateByType(string type)
        {
            return type.ToLower() switch
            {
                "domestic" => new DomesticSubscription(),
                "educational" => new EducationalSubscription(),
                "premium" => new PremiumSubscription(),
                _ => throw new ArgumentException("Невідомий тип підписки.")
            };
        }
    }
}
