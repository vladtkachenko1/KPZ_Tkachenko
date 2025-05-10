using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class AccountStep : SupportStep
    {
        public override SupportStep? Execute()
        {
            Console.WriteLine("\nПроблема з акаунтом:");
            var options = new Dictionary<string, string>
            {
                ["1"] = "Не можу увійти",
                ["2"] = "Забутий пароль",
                ["3"] = "Акаунт заблоковано"
            };
            PrintOptions(options);

            string? choice = GetInput();

            if (choice == "3")
            {
                Console.WriteLine("\nПричина блокування:");
                var subOptions = new Dictionary<string, string>
                {
                    ["1"] = "Підозра на злом",
                    ["2"] = "Перевищено ліміт помилок"
                };
                PrintOptions(subOptions);

                return GetInput() switch
                {
                    "1" => AssignHandler("Відділ безпеки (4 рівень)") ? null : null,
                    "2" => AssignHandler("Підтримка акаунтів (3 рівень)") ? null : null,
                    _ => null
                };
            }

            return choice switch
            {
                "1" => AssignHandler("Техпідтримка акаунтів (1 рівень)") ? null : null,
                "2" => AssignHandler("Скидання паролю (2 рівень)") ? null : null,
                _ => null
            };
        }
    }

}
