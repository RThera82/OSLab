using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> urls = new List<String>
            {
                "http://sutech.ac.ir/file/download/page/6586c7744f75b-45.pdf"
            };
                DownloadManager downloadManager = new DownloadManager();
                foreach (var url in urls)
                {
                    downloadManager.AddDownload(url);
                }
                downloadManager.StartDownloads();
                MessageBox.Show("Donwloaded successfully");
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> urls = new List<String>
            {
                "http://sutech.ac.ir/file/download/page/6586c9110975e-01-tarmimsabtnam-0.docx"
            };
                DownloadManager downloadManager = new DownloadManager();
                foreach (var url in urls)
                {
                    downloadManager.AddDownload(url);
                }
                downloadManager.StartDownloads();
                MessageBox.Show("Donwloaded successfully");
            }catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> urls = new List<String>
            {
                "http://sutech.ac.ir/file/download/page/6586c99de0ce6-tak-dars-other-faculties.pdf"
            };
                DownloadManager downloadManager = new DownloadManager();
                foreach (var url in urls)
                {
                    downloadManager.AddDownload(url);
                }
                downloadManager.StartDownloads();
                MessageBox.Show("Donwloaded successfully");
            }catch (Exception ex)
            {
                MessageBox.Show("Error:" +ex.Message);    
            }
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
        foreach (var url in downloadQueue)
        {
            var task = Task.Run(() => DownloadFile(url));
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
