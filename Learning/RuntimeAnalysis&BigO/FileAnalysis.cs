using System.Diagnostics;
using System.Security.Cryptography;

namespace ConsoleAppLearning1.Learning.RuntimeAnalysis_BigO;

public class FileAnalysis
{
    public void Analaysis()
    {
        Stopwatch Stopwatch = new Stopwatch();
        FileStream fs = new FileStream("analysis3.txt", FileMode.Create ,FileAccess.ReadWrite);
        byte[] bytes = new byte[1024 * 1024]; //that is 1 MB 
        for (int i = 0; i < 500; i++)
        {
            fs.Write(bytes, 0, bytes.Length);
        }

        fs.Flush();
        fs.Position = 0;
        //StreamReader
        StreamReader sr  = new StreamReader("analysis3.txt");
        int utf;
        int s;
        Stopwatch.Start();
        while ((utf = sr.Read()) != -1)
        {
            
        }
        Stopwatch.Stop();
        Console.WriteLine(Stopwatch.ElapsedMilliseconds);
        Stopwatch.Reset();
        //Filestream
        Stopwatch.Start();

        while ((s = fs.ReadByte()) != -1)
        {
        }
        Stopwatch.Stop();
        Console.WriteLine(Stopwatch.ElapsedMilliseconds);
    }
}