using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    public class SmartTextChecker : SmartTextReader
    {
        private SmartTextReader _reader = new SmartTextReader();

        public override char[][] ReadText(string filePath)
        {
            Console.WriteLine($"[INFO] Відкриття файлу: {filePath}");

            var content = _reader.ReadText(filePath);

            int linesCount = content.Length;
            int charsCount = 0;
            foreach (var line in content)
                charsCount += line.Length;

            Console.WriteLine($"[INFO] Прочитано рядків: {linesCount}, символів: {charsCount}");
            Console.WriteLine("[INFO] Закриття файлу.");

            return content;
        }
    }

}
