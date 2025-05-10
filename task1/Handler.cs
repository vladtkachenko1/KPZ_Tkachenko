using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class SupportHandler
    {
        protected SupportHandler? NextHandler;

        public void SetNext(SupportHandler next)
        {
            NextHandler = next;
        }

        public abstract bool Handle(string answer);
    }

}
