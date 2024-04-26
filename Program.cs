using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace IDM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> urls = new List<String>
            {
                "https://cdn.behmusic.com/music/1401/09/Album/Hiphopologist%20-%20Capsule/Hiphopologist%20-%20Capsule%20[320]/Hiphopologist%20-%20GHORS%20II%20(feat.%20Poobon).mp3",
                "https://dl.melonmusic.ir/Music/Sijal%20-%20Ey%20Jan%20(320).mp3"

            };
            DownloadManager downloadManager = new DownloadManager();
            foreach(var url in urls)
            {
                downloadManager.AddDownload(url);
            }
            downloadManager.StartDownloads();
            Console.WriteLine("Press any ket to exit");
            Console.ReadKey();
        }
    }
}
class DownloadManager
{
    private List<String> downloadQueue = new List<String>();
    private List<Task> downloadTasks = new List<Task>();
    public void AddDownload(String url)
    {
        downloadQueue.Add(url);
    }
    public void StartDownloads()
    {
        foreach(var url in downloadQueue)
        {
            var task = Task.Run( ()=>DownloadFile(url) );  
            downloadTasks.Add(task);
        }
        Task.WaitAll(downloadTasks.ToArray());
        Console.WriteLine("All downloads completed.");

    }
    private void DownloadFile(String url)
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                Uri uri = new Uri(url);
                String fileName = Path.GetFileName(uri.LocalPath);
                client.DownloadFile(url, fileName);
                Console.WriteLine("$Downloaded {fileName} from {url}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("$Error downloading {url}:{ex.Message}");

            }
        }
    }
}
