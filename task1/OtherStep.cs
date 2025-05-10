using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class OtherStep : SupportStep
    {
        public override SupportStep? Execute()
        {
            Console.WriteLine("\nІнші питання:");
            var options = new Dictionary<string, string>
            {
                ["1"] = "Консультація",
                ["2"] = "Підключення нових послуг",
                ["3"] = "Скарга"
            };
            PrintOptions(options);

            return GetInput() switch
            {
                "1" => AssignHandler("Консультант (1 рівень)") ? null : null,
                "2" => AssignHandler("Менеджер (2 рівень)") ? null : null,
                "3" => AssignHandler("Відділ скарг (3 рівень)") ? null : null,
                _ => null
            };
        }
    }

}
