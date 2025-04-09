using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace Composer
{


    public static class Parser
    {
        public static LightElementNode ParseBook(string filePath, ElementFlyweightFactory factory)
        {
            var lines = File.ReadAllLines(filePath);
            var root = factory.GetElement("div"); // Кореневий вузол

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                string tag;
                if (i == 0)
                    tag = "h1";
                else if (line.Length < 20)
                    tag = "h2";
                else if (char.IsWhiteSpace(line[0]))
                    tag = "blockquote";
                else
                    tag = "p";

                var element = factory.GetElement(tag);
                element.AddChild(new LightTextNode(line.Trim()));
                root.AddChild(element);
            }

            return root;
        }
    }

}
