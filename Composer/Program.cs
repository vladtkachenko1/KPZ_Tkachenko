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

                int localIndex = i; 
                li.AddEventListener("click", () => Console.WriteLine($"Клік по елементу списку {localIndex}"));
                li.AddEventListener("mouseover", () => Console.WriteLine($"Мишка на елементі списку {localIndex}"));

                ul.AddChild(li);
            }

            Console.WriteLine("innerHTML:");
            Console.WriteLine(ul.InnerHTML());

            Console.WriteLine("\nouterHTML:");
            Console.WriteLine(ul.OuterHTML());

            Console.WriteLine("\nСимуляція подій для кожного елемента списку:");
            SimulateEvents(ul); 
        }

        // Метод для симуляції подій
        static void SimulateEvents(LightElementNode ul)
        {
            foreach (var child in ul.Children)
            {
                if (child is LightElementNode elementNode)
                {
                    Console.WriteLine($"Симуляція події 'click' для елемента: {elementNode.InnerHTML()}");
                    elementNode.TriggerEvent("click");

                    Console.WriteLine($"Симуляція події 'mouseover' для елемента: {elementNode.InnerHTML()}");
                    elementNode.TriggerEvent("mouseover");
                }
            }
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
