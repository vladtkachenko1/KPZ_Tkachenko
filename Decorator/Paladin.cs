using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Paladin : IHero
    {
        public string GetDescription() => "Паладін";
        public int GetPower() => 9;
    }
}
