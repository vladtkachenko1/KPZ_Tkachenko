using System;

namespace Composer
{
    public class StandardHtmlFactory : ILightNodeFactory
    {
        private readonly string _imageFolder;

        public StandardHtmlFactory(string imageFolder = "DownloadedImages")
        {
            _imageFolder = imageFolder;
        }

        public LightElementNode CreateElement(string tagName)
        {
            return new LightElementNode(tagName);
        }

        public LightTextNode CreateText(string text)
        {
            return new LightTextNode(text);
        }

        public LightImageNode CreateImage(string source)
        {
            return new LightImageNode(source, new FileImageLoadingStrategy(), _imageFolder);
        }
    }
}
