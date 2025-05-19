using Composer;
using System.Net;

public class NetworkImageLoadingStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href, string targetFolder)
    {
        try
        {
            Directory.CreateDirectory(targetFolder);
            string fileName = Path.GetFileName(new Uri(href).LocalPath);
            string destinationPath = Path.Combine(targetFolder, fileName);

            using (var client = new WebClient())
            {
                client.DownloadFile(href, destinationPath);
            }

            return destinationPath;
        }
        catch (Exception ex)
        {
            return $"[Помилка завантаження: {ex.Message}]";
        }
    }
}
