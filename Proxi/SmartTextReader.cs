using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxi
{
    public class SmartTextReader
    {
        public virtual char[][] ReadText(string filePath)
        {
            List<char[]> lines = new List<char[]>();
            foreach (var line in File.ReadLines(filePath))
            {
                lines.Add(line.ToCharArray());
            }
            return lines.ToArray();
        }
    }

}
