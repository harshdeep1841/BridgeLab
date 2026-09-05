namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.Multi_Threading;

public class SingleThreadCreation
{
   static public void Method1()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        for(int i = 0 ; i < 5 ; i++)
        {
            
            Console.WriteLine($"{Thread.CurrentThread.Name} {i}");
            Thread.Sleep(1000);
        }
    }


    public static void MainThread()
    {
        Thread thread1 = new Thread(Method1);
        // Thread thread2 = new Thread(Method1);
        thread1.Priority = ThreadPriority.Lowest;
        // thread2.Priority = ThreadPriority.Highest;
        thread1.Name = "MainThread1";
        // thread2.Name = "MainThread2";
        //thread1.IsBackground = true;
        thread1.Start();
        // thread1.Join();
        // thread2.Start();
        // thread2.Join();
      //  Console.WriteLine(thread1.IsAlive);
        Thread.Sleep(1000);
        Console.WriteLine("Main thread finishes");
        Console.WriteLine(Thread.CurrentThread);
    }
}