using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ConnectionStep : SupportStep
    {
        public override SupportStep? Execute()
        {
            Console.WriteLine("\nПроблема з підключенням:");
            var options = new Dictionary<string, string>
            {
                ["1"] = "Погано працює Wi-Fi",
                ["2"] = "Зламаний кабель",
                ["3"] = "Не працює модем"
            };
            PrintOptions(options);

            return GetInput() switch
            {
                "1" => AssignHandler("Оператор Wi-Fi (1 рівень)") ? null : null,
                "2" => AssignHandler("Кабельний інженер (2 рівень)") ? null : null,
                "3" => AssignHandler("Технік по обладнанню (3 рівень)") ? null : null,
                _ => null
            };
        }
    }

}
