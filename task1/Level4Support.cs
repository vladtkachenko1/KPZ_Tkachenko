using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Level4Support : SupportHandler
    {
        public override bool Handle(string answer)
        {
            if (answer == "4")
            {
                Console.WriteLine("Вас з'єднано з оператором Четвертого рівня підтримки.");
                return true;
            }
            return false;
        }
    }
}
