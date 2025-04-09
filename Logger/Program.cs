using Adapter;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Консольний логер ===");
        Logger consoleLogger = new Logger();
        consoleLogger.Log("Усе працює нормально.");
        consoleLogger.Error("Сталася помилка!");
        consoleLogger.Warn("Це може бути проблемою.");

        Console.WriteLine("\n=== Файловий логер (через Адаптер) ===");
        FileWriter fileWriter = new FileWriter("log.txt");
        IAdvancedLogger fileLogger = new FileLoggerAdapter(fileWriter);
        fileLogger.Log("Файл: система запущена.");
        fileLogger.Error("Файл: диск не знайдено.");
        fileLogger.Warn("Файл: недостатньо памʼяті.");

        Console.WriteLine("Повідомлення записано у log.txt");
    }
}
