using task1;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            SupportStep step = new MainMenuStep();
            while (step != null)
            {
                step = step.Execute();
            }

            Console.WriteLine("\nБажаєте звернутися ще раз? (так/ні)");
            string? again = Console.ReadLine()?.ToLower();
            if (again != "так") break;
        }

        Console.WriteLine("Дякуємо за звернення!");
    }
}
