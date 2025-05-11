using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public interface IImageLoadingStrategy
    {
        string LoadImage(string href, string targetFolder);
    }
}

