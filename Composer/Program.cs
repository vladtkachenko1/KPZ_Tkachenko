namespace Composer
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("========= ФІЧІ ПРОЄКТУ =========");

            Console.WriteLine("\n========= Шаблон 1: Шаблонний метод =========");
            RunTemplateMethodDemo();

            Console.WriteLine("\n========= Шаблон 2: Ітератор =========");
            RunIteratorDemo();

            Console.WriteLine("\n========= Шаблон 3: Команда =========");
            RunCommandPatternDemo();

            Console.WriteLine("\n========= Шаблон 4: Стейт =========");
            RunStatePatternDemo();

            Console.WriteLine("\n========= Шаблон 5: Відвідувач =========");
            RunVisitorDemo();




            Console.WriteLine("\n\n========= Демонстрація Виконання завдання 4 Лабораторної роботи №4 =========");
            RunTask4();

            Console.WriteLine("\n========= Завдання 5 =========");
            RunTask5();

            Console.WriteLine("\n========= Завдання 6 =========");
            RunTask6();
        }
        static void RunTemplateMethodDemo()
        {
            var div = new CustomDivElement();
            div.RenderWithLifecycle();
        }
        static void RunIteratorDemo()
        {
            var div = new LightElementNode("div");
            var p = new LightElementNode("p");
            var span = new LightElementNode("span");
            var text1 = new LightTextNode("Це текст у span");
            var text2 = new LightTextNode("Це текст у p");

            span.AddChild(text1);
            p.AddChild(span);
            p.AddChild(text2);
            div.AddChild(p);

            var iterator = new ElementIterator(div);

            Console.WriteLine("Обхід елементів дерева:");
            while (iterator.HasNext())
            {
                var node = iterator.Next();
                if (node is LightTextNode textNode)
                {
                    Console.WriteLine($"Text node: {textNode.Text}");
                }
                else if (node is LightElementNode elementNode)
                {
                    Console.WriteLine($"Element node: <{elementNode.TagName}>");
                }
            }
        }
        static void RunCommandPatternDemo()
        {
            var invoker = new CommandInvoker();
            var div = new LightElementNode("div");
            var span = new LightElementNode("span");
            var text = new LightTextNode("Привіт, світ!");

            var addTextCommand = new AddElementCommand(span, text);
            var addSpanCommand = new AddElementCommand(div, span);
            var addClassCommand = new AddClassCommand(div, "highlight");

            invoker.ExecuteCommand(addClassCommand);
            invoker.ExecuteCommand(addSpanCommand);
            invoker.ExecuteCommand(addTextCommand);

            Console.WriteLine("HTML після виконання команд:");
            Console.WriteLine(div.OuterHTML());

            Console.WriteLine("\nСкасовуємо останню команду:");
            invoker.UndoLast();
            Console.WriteLine(div.OuterHTML());

            Console.WriteLine("\nСкасовуємо ще одну команду:");
            invoker.UndoLast();
            Console.WriteLine(div.OuterHTML());
        }
        static void RunStatePatternDemo()
        {
            var div = new LightElementNode("div");

            div.SetState(new VisibleState());
            div.ApplyCurrentState();

            div.SetState(new HiddenState());
            div.ApplyCurrentState();

            div.SetState(new DisabledState());
            div.ApplyCurrentState();

            Console.WriteLine("HTML:");
            Console.WriteLine(div.OuterHTML());
        }

        static void RunVisitorDemo()
        {
            var div = new LightElementNode("div");
            var p = new LightElementNode("p");
            var span = new LightElementNode("span");

            span.AddChild(new LightTextNode("Привіт"));
            p.AddChild(span);
            p.AddChild(new LightTextNode("світ!"));
            div.AddChild(p);

            Console.WriteLine("Відвідування вузлів дерева HTML...");

            var textVisitor = new TextContentCollectorVisitor();
            div.Accept(textVisitor);

            Console.WriteLine("\n---Зібраний текст---");
            Console.WriteLine(textVisitor.GetText());


            Console.WriteLine("\n---Кількість елементів---");
            var countVisitor = new NodeCounterVisitor();
            div.Accept(countVisitor);

            countVisitor.PrintCounts();
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
