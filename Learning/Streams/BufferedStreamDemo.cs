namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.Diagnostics;
using System.IO;

    public class BufferedStreamDemo
    {
        public static void CopyWithBuffer()
        {
            string sourceFile = "/Users/harshdeepsingh/RiderProjects/ConsoleAppLearning/input.txt";
            string destinationFile = "/Users/harshdeepsingh/RiderProjects/ConsoleAppLearning/output_buffered.txt";

            try
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                using FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                using BufferedStream bsRead = new BufferedStream(fsRead);

                using FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write);
                using BufferedStream bsWrite = new BufferedStream(fsWrite);

                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }

                stopwatch.Stop();

                Console.WriteLine("Buffered Copy Completed.");
                Console.WriteLine("Execution Time: " + stopwatch.ElapsedMilliseconds + " ms");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }