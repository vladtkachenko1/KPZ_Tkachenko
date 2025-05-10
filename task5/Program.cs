
using task5;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        TextEditor editor = new TextEditor();
        bool running = true;

        Console.WriteLine("Текстовий редактор (патерн Memento)");
        Console.WriteLine("-----------------------------------");

        while (running)
        {
            Console.WriteLine("Оберіть дію:");
            Console.WriteLine("1. Додати рядок");
            Console.WriteLine("2. Скасувати останню зміну");
            Console.WriteLine("3. Показати документ");
            Console.WriteLine("4. Вийти");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введіть рядок: ");
                    string line = Console.ReadLine();
                    editor.AddLine(line);
                    break;

                case "2":
                    editor.Undo();
                    break;

                case "3":
                    editor.Show();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Редактор завершив роботу.");
    }
}