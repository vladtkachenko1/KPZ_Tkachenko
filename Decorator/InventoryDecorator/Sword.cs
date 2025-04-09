using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.InventoryDecorator
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " з мечем";
        public override int GetPower() => hero.GetPower() + 5;
    }
}
