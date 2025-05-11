using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            return $"<img src=\"{href}\"/>";
        }
    }
}
