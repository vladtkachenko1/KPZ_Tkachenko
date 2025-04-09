using System;
using Composer;

namespace Composer
{
    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========= Завдання 5 =========");
            RunTask5();

            Console.WriteLine("\n========= Завдання 6 =========");
            RunTask6();
        }

        static void RunTask5()
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

        static void RunTask6()
        {
            var factory = new ElementFlyweightFactory();
            long memBefore = GC.GetTotalMemory(true);

            var htmlTree = Parser.ParseBook("kniga.txt", factory);

            long memAfter = GC.GetTotalMemory(true);
            long usedMemory = memAfter - memBefore;

            Console.WriteLine($"\nВикористано памʼяті: {usedMemory} байт");
            Console.WriteLine("\nouterHTML:");
            Console.WriteLine(htmlTree.OuterHTML());
        }
    }
}
