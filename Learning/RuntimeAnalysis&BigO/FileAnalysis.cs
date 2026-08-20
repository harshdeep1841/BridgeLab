using System.Diagnostics;
using System.Security.Cryptography;

namespace ConsoleAppLearning1.Learning.RuntimeAnalysis_BigO;

public class FileAnalysis
{
    public void Analaysis()
    {
        //FileStream
        Stopwatch Stopwatch = new Stopwatch();
        Stopwatch.Start();
        FileStream fs = new FileStream("analysis.txt", FileMode.Create);
        Byte[] bytes = new Byte[1024 * 1024]; //that is 1 MB 
        for (int i = 0; i < 500; i++)
        {
            fs.Write(bytes, 0, bytes.Length);
        }

        Stopwatch.Stop();
        Console.WriteLine(Stopwatch.ElapsedMilliseconds);
        //StreamReader
        Stopwatch.Reset();
        Stopwatch.Start();
        StreamReader sr  = new StreamReader(new FileStream("analysis.txt", FileMode.Create));
        
        
    }
}