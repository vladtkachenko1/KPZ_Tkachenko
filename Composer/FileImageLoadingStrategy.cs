using System.IO;

namespace Composer
{
    public class FileImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href, string targetFolder)
        {
            if (!File.Exists(href))
                return $"[Файл '{href}' не знайдено]";

            string fileName = Path.GetFileName(href);
            string destinationPath = Path.Combine(targetFolder, fileName);

            Directory.CreateDirectory(targetFolder); // Створює папку, якщо її ще нема
            File.Copy(href, destinationPath, overwrite: true);

            return destinationPath;
        }
    }

}
