// Section 22
// 349 - Threads Basics

namespace Thread_App1;

class Program
{
    static void Main(string[] args)
    {
        /*
         Console.WriteLine("Hello, World! 1");
         Thread.Sleep(1000);

         Console.WriteLine("Hello, World! 2");
         Thread.Sleep(1000);

         Console.WriteLine("Hello, World! 3");
         Thread.Sleep(1000);

         Console.WriteLine("Hello, World! 4");
         */

        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thead 1");
        }).Start();
        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thead 2");
        }).Start();

        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thead 3");
        }).Start();
        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thead 4");
        }).Start();
    }
}