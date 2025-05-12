using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class CustomDivElement : LifecycleElement
    {
        public CustomDivElement() : base("div") { }

        protected override void OnCreated()
        {
            Console.WriteLine("CustomDivElement: OnCreated");
        }

        protected override void OnInserted()
        {
            Console.WriteLine("CustomDivElement: OnInserted");
        }

        protected override void OnStylesApplied()
        {
            Console.WriteLine("CustomDivElement: OnStylesApplied");
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine("CustomDivElement: OnClassListApplied");
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine("CustomDivElement: OnTextRendered");
        }
    }

}
