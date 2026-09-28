namespace ConsoleAppLearning1.Learning.Operator.Learning.Test;

using System;
using System.Threading;
public class HelloWorld {
    public async static void Main_Sample() {

        // for(int i = 0 ; i < 5 ; i++)
        // {
        //     // ThreadPool.QueueUserWorkItem(ProcessJob , i);
        //     
        // }
        
        Task<int> task1 = Task.Run(() => ProcessJob(1));
       // task1.Wait();
        Task task2 = Task.Run(() => ProcessJob(2));
        Task task3 = Task.Run(() => ProcessJob(3));
        Task task4 = Task.Run(() => ProcessJob(4));
        Task task5 = Task.Run(() => ProcessJob(5));
        await Task.WhenAll(task1, task2, task3, task4, task5);
        int result = task1.Result;
        Console.WriteLine(result);
        Console.WriteLine("Hello World!");
    }

    public  static int ProcessJob(int process_id)
    {
        Console.WriteLine($"Process id : {process_id}");
        Thread.Sleep(4000);
         //Task.Delay(4000);a
        Console.WriteLine($"{process_id} completed");
        return process_id*10;
    }
}