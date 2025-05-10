using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class TextEditor
    {
        private TextDocument document = new TextDocument();
        private Stack<DocumentMemento> history = new Stack<DocumentMemento>();

        public void AddLine(string line)
        {
            Save();
            document.AddLine(line);
        }

        public void Save()
        {
            history.Push(new DocumentMemento(document.GetContent()));
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                var previousState = history.Pop();
                document.SetContent(previousState.GetSavedState());
                Console.WriteLine("Останню зміну скасовано.");
            }
            else
            {
                Console.WriteLine("Немає змін для скасування.");
            }
        }

        public void Show()
        {
            document.Show();
        }
    }
}
