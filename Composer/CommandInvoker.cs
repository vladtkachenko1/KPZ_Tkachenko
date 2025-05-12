using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Composer
{
    public class CommandInvoker
    {
        private Stack<ICommand> _history = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLast()
        {
            if (_history.Count > 0)
            {
                var command = _history.Pop();
                command.Undo();
            }
        }
    }

}
