using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Level1Support : SupportHandler
    {
        public override bool Handle(string answer)
        {
            if (answer == "1")
            {
                Console.WriteLine("Вас з'єднано з оператором Першого рівня підтримки.");
                return true;
            }
            return NextHandler?.Handle(answer) ?? false;
        }
    }
}
