using Composer;

namespace Composer
{
    class Program
    {
        static void Main()
        {
            var ul = new LightElementNode("ul");
            ul.AddClass("my-list");

            for (int i = 1; i <= 3; i++)
            {
                var li = new LightElementNode("li");
                li.AddChild(new LightTextNode($"Елемент списку {i}"));
                ul.AddChild(li);
            }

            Console.WriteLine("innerHTML:");
            Console.WriteLine(ul.InnerHTML());

            Console.WriteLine("\nouterHTML:");
            Console.WriteLine(ul.OuterHTML());
        }
    }
}