using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ManagerCallCreator : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("[Оформлення через дзвінок менеджера]");
            Console.WriteLine("Менеджер надає знижку 10% на щомісячну плату.");
            Subscription sub = CreateByType(type);
            return new DiscountedSubscription(sub, 0.1m);
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
