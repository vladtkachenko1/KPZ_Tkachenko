using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public interface ILightNodeFactory
    {
        LightElementNode CreateElement(string tagName);
        LightTextNode CreateText(string text);
        LightImageNode CreateImage(string source);
    }

}
