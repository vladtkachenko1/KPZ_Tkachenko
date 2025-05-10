using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Level2Support : SupportHandler
    {
        public override bool Handle(string answer)
        {
            if (answer == "2")
            {
                Console.WriteLine("Вас з'єднано з оператором Другого рівня підтримки.");
                return true;
            }
            return NextHandler?.Handle(answer) ?? false;
        }
    }
}
