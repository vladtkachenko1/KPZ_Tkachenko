using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class NodeCounterVisitor : ILightNodeVisitor
    {
        public int ElementCount { get; private set; } = 0;
        public int TextNodeCount { get; private set; } = 0;
        public int ImageCount { get; private set; } = 0;

        public void VisitElement(LightElementNode element)
        {
            ElementCount++;
        }

        public void VisitText(LightTextNode text)
        {
            TextNodeCount++;
        }

        public void VisitImage(LightImageNode image)
        {
            ImageCount++;
        }

        public void PrintCounts()
        {
            Console.WriteLine($"Елементи: {ElementCount}");
            Console.WriteLine($"Текстові вузли: {TextNodeCount}");
            Console.WriteLine($"Вузли зображень: {ImageCount}");

        }
    }

}
