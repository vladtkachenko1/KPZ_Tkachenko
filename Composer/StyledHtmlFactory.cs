using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    using System;

    namespace Composer
    {
        public class StyledHtmlFactory : ILightNodeFactory
        {
            private readonly string _imageFolder;
            private readonly string _cssClass;

            public StyledHtmlFactory(string cssClass = "styled", string imageFolder = "StyledImages")
            {
                _cssClass = cssClass;
                _imageFolder = imageFolder;
            }

            public LightElementNode CreateElement(string tagName)
            {
                var element = new LightElementNode(tagName);
                element.AddClass(_cssClass);
                return element;
            }

            public LightTextNode CreateText(string text)
            {
                return new LightTextNode(text.ToUpper());
            }

            public LightImageNode CreateImage(string source)
            {
                return new LightImageNode(source, new NetworkImageLoadingStrategy(), _imageFolder);
            }
        }
    }


}
