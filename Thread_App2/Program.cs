namespace Thread_App2;

class Program
{
    static void Main(string[] args)
    {
        var taskCompletionSource = new TaskCompletionSource<bool>();

        var thread = new Thread(() =>
        {
            Console.WriteLine($"Thread number:  {Thread.CurrentThread.ManagedThreadId} Started");
            Thread.Sleep(5000);
            taskCompletionSource.TrySetResult(true);
            Console.WriteLine($"Thread number:  {Thread.CurrentThread.ManagedThreadId} Completed");
        });
        
       thread.Start();
       var test = taskCompletionSource.Task.Result;
       Console.WriteLine($"Thread number:  {test} was done");
       Console.ReadLine();

    }
}