using System.IO;

namespace Composer
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            return File.Exists(href) ? $"<img src=\"file://{href}\"/>" : $"<!-- File not found: {href} -->";
        }
    }
}
