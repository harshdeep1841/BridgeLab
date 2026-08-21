using System.Diagnostics;
using System.Text;

namespace ConsoleAppLearning1.Learning.Streams;

public class ComparePerformance
{
    public void Compare()
    {
        string str = "";
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int iternations = 10000;
        for (int i = 0; i < iternations; i++)
        {
            str += "Hello";
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < iternations; i++)
        {
            sb.Append("Hello");
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}