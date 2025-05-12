using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Composer
{
    public class AddElementCommand : ICommand
    {
        private LightElementNode _parent;
        private LightNode _child;

        public AddElementCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            _parent.AddChild(_child);
        }

        public void Undo()
        {
            _parent.Children.Remove(_child);
        }
    }

}
