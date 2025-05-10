using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class TextDocument
    {
        private List<string> lines = new List<string>();

        public void AddLine(string line)
        {
            lines.Add(line);
        }

        public void SetContent(List<string> newContent)
        {
            lines = new List<string>(newContent);
        }

        public List<string> GetContent()
        {
            return new List<string>(lines);
        }

        public void Show()
        {
            Console.WriteLine("\n--- Вміст документу ---");
            if (lines.Count == 0)
                Console.WriteLine("[Документ порожній]");
            else
                foreach (var line in lines)
                    Console.WriteLine(line);
            Console.WriteLine("------------------------\n");
        }
    }
}
