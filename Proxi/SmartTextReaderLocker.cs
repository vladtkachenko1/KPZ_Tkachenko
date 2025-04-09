using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Proxi
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private SmartTextReader _reader = new SmartTextReader();
        private Regex _restrictedPattern;

        public SmartTextReaderLocker(string pattern)
        {
            _restrictedPattern = new Regex(pattern);
        }

        public override char[][] ReadText(string filePath)
        {
            if (_restrictedPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadText(filePath);
        }
    }

}
