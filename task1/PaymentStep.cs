using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class PaymentStep : SupportStep
    {
        public override SupportStep? Execute()
        {
            Console.WriteLine("\nПроблема з оплатою:");
            var options = new Dictionary<string, string>
            {
                ["1"] = "Не проходить платіж",
                ["2"] = "Подвійне списання",
                ["3"] = "Помилка у рахунку"
            };
            PrintOptions(options);

            return GetInput() switch
            {
                "1" => AssignHandler("Фінансовий консультант (1 рівень)") ? null : null,
                "2" => AssignHandler("Бухгалтерія (2 рівень)") ? null : null,
                "3" => AssignHandler("Контроль рахунків (3 рівень)") ? null : null,
                _ => null
            };
        }
    }

}
