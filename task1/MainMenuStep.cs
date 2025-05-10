using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class MainMenuStep : SupportStep
    {
        public override SupportStep? Execute()
        {
            Console.WriteLine("\nВітаємо в системі підтримки!");
            var options = new Dictionary<string, string>
            {
                ["1"] = "Проблема з підключенням",
                ["2"] = "Проблема з оплатою",
                ["3"] = "Проблема з акаунтом",
                ["4"] = "Інше"
            };
            PrintOptions(options);

            return GetInput() switch
            {
                "1" => new ConnectionStep(),
                "2" => new PaymentStep(),
                "3" => new AccountStep(),
                "4" => new OtherStep(),
                _ => null
            };
        }
    }

}
