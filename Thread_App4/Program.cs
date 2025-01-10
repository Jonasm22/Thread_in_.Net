// Section 22
// 352 -Join And IsAlive

namespace Thread_App4;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Main Thread Started");

        Thread thread1 = new Thread(ThreadFunction1);
        Thread thread2 = new Thread(ThreadFunction2);
        
        thread1.Start();
        thread2.Start();
        
        thread1.Join();
        Console.WriteLine("Thread 1 Ended");
        thread2.Join();
        Console.WriteLine("Thread 2 Ended");

        if (thread1.Join(1000))
        {
            Console.WriteLine("Thread function 1 done");            
        }
        else
        {
            Console.WriteLine("Thread wasn't done in 1 second");
        }


        thread2.Join();
        Console.WriteLine("Thread 2 Function Ended");

        for (int i = 0; i < 10; i++)
        {
            
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread function 1 is alive");
            }
            else
            {
                Console.WriteLine("Thread 1 was done");
            }

        }
        
        
        
        
        Console.WriteLine("Main Thread ended");
        
    }



    public static void ThreadFunction1()
    {
        
        Console.WriteLine("ThreadFunction1 started");
        Thread.Sleep(300);
        Console.WriteLine("ThreadFunction1  coming back to caller");
    } 
    
    
    public static void ThreadFunction2()
    {
        Console.WriteLine("ThreadFunction2 started");
    } 
    
    
}