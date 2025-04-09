namespace Proxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string path = "test.txt";
            File.WriteAllLines(path, new[] { "Привіт", "Світ" });

            Console.WriteLine("\n--- SmartTextChecker ---");
            SmartTextReader checker = new SmartTextChecker();
            checker.ReadText(path);

            Console.WriteLine("\n--- SmartTextReaderLocker (доступ дозволено) ---");
            SmartTextReader locker = new SmartTextReaderLocker(@"^forbidden.*$");
            locker.ReadText(path);

            Console.WriteLine("\n--- SmartTextReaderLocker (доступ заборонено) ---");
            SmartTextReader locked = new SmartTextReaderLocker(@"^test\.txt$");
            locked.ReadText(path);
        }
    }
}
