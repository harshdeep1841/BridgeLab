using System.Diagnostics;
using System.Text;

namespace ConsoleAppLearning1.Learning.RuntimeAnalysis_BigO;

public class StringAnalysis
{
    public void Analysis()
    {
        //String
        string str = "";
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            str += "Hello World";
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("Hello World");
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        
    }
}