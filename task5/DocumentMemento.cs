using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class DocumentMemento
    {
        private readonly List<string> content;

        public DocumentMemento(List<string> state)
        {
            content = new List<string>(state);
        }

        public List<string> GetSavedState()
        {
            return new List<string>(content);
        }
    }
}
