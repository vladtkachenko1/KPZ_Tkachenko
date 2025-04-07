using FactoryMetрod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WebsiteCreator : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("[Оформлення через вебсайт]");
            return CreateByType(type);
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
