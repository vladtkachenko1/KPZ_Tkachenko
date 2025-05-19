using System.Text;

namespace Composer
{
    public class TextContentCollectorVisitor : ILightNodeVisitor
    {
        private StringBuilder _builder = new StringBuilder();

        public void VisitElement(LightElementNode element)
        {
            Console.WriteLine($"Відвідано елемент <{element.TagName}>");

        }

        public void VisitText(LightTextNode text)
        {
            _builder.Append(text.Text + " ");
        }

        public void VisitImage(LightImageNode image)
        {
            // За бажанням: можна додати текст alt чи src
        }

        public string GetText()
        {
            return _builder.ToString().Trim();
        }
    }
}
