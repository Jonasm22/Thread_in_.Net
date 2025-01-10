// Section 22
// 351 -ThreadPools and Threads in The Background

using System.Net;

namespace Thread_App3;

class Program
{
    static void Main(string[] args)
    {
    
        
    }




    public static void ExerciseWhitEnumerable()
    {

        Enumerable.Range(0, 1000).ToList().ForEach(f =>
        {
            new Thread(() =>
            {
                Console.WriteLine($"Thread Number : {Thread.CurrentThread.ManagedThreadId} Started");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread Number : {Thread.CurrentThread.ManagedThreadId} Completed");

            }).Start();
        });

    }
    
    public static void ExerciseWhitThreadPool()
    {

        Enumerable.Range(0, 1000).ToList().ForEach(f =>
        {
            ThreadPool.QueueUserWorkItem((Myobject) =>
            {
                Console.WriteLine($"Thread Number : {Thread.CurrentThread.ManagedThreadId} Started");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread Number : {Thread.CurrentThread.ManagedThreadId} Completed");

            });
        });

        Console.ReadLine();

    }
    
    
    public static void ImagenDowloads()
    {
        // it will find the Download Folder 
        string downloadsFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        // Lista of URLs 
        List<string> urls = new List<string>
        {
            "https://journalistikon.de/wp-content/uploads/2024/06/Memes-Journalisten.jpeg",
            "https://cdn.netzpolitik.org/wp-upload/one-does-not-meme.jpg",
            // ... Add more  URLs
        };

        urls.ForEach(url =>
        {
            new Thread(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Started Downloading {url}");

                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string fileName = Path.Combine(downloadsFolder,
                            $"image_{Thread.CurrentThread.ManagedThreadId}.jpg");
                        client.DownloadFile(url, fileName);
                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Completed Downloading {url}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Failed: {ex.Message}");
                    }
                }
            }).Start();
        });

        Console.WriteLine($"All the image will be save here:  {downloadsFolder}");
    }
    
    
    
}



