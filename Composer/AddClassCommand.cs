using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Composer
{
    public class AddClassCommand : ICommand
    {
        private LightElementNode _element;
        private string _className;

        public AddClassCommand(LightElementNode element, string className)
        {
            _element = element;
            _className = className;
        }

        public void Execute()
        {
            _element.AddClass(_className);
        }

        public void Undo()
        {
            _element.CssClasses.Remove(_className);
        }
    }

}
