using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.InventoryDecorator
{
    public class Amulet : HeroDecorator
    {
        public Amulet(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " з амулетом";
        public override int GetPower() => hero.GetPower() + 2;
    }
}
