using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class VisibleState : IElementState
    {
        public void Apply(LightElementNode element)
        {
            Console.WriteLine($"Стан застосовано: Visible для <{element.TagName}>");
            element.AddClass("visible");
        }

        public string GetStateName() => "Visible";
    }
}
