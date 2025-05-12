using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class HiddenState : IElementState
    {
        public void Apply(LightElementNode element)
        {
            Console.WriteLine($"Стан застосовано: Hidden для <{element.TagName}>");
            element.AddClass("hidden");
        }

        public string GetStateName() => "Hidden";
    }

}
