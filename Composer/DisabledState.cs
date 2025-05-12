using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class DisabledState : IElementState
    {
        public void Apply(LightElementNode element)
        {
            Console.WriteLine($"Стан застосовано: Disabled для <{element.TagName}>");
            element.AddClass("disabled");
        }

        public string GetStateName() => "Disabled";
    }
}
