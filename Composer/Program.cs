namespace Composer
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========= Демонстрація Виконання завдання 4 Лабораторної роботи №4 =========");
            RunTask4();

            Console.WriteLine("========= Завдання 5 =========");
            RunTask5();

            Console.WriteLine("\n========= Завдання 6 =========");
            RunTask6();
        }

        static void RunTask4()
        {
            var imageFolder = "DownloadedImages";

            var fileImage = new LightImageNode("C:\\Users\\User\\Downloads\\природа.jpeg", new FileImageLoadingStrategy(), imageFolder);
            var webImage = new LightImageNode("https://wallpaper.forfun.com/fetch/20/2032496c8644d978861803bee90e18c0.jpeg", new NetworkImageLoadingStrategy(), imageFolder);

            Console.WriteLine("file image HTML: " + fileImage.OuterHTML());
            Console.WriteLine("web image HTML: " + webImage.OuterHTML());
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
