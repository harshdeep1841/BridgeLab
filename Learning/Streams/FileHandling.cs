namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.IO;

    public class FileHandling
    {
        public static void CopyFile()
        {
            string sourceFile = "/Users/harshdeepsingh/RiderProjects/ConsoleAppLearning/input.txt";
            string destinationFile = "/Users/harshdeepsingh/RiderProjects/ConsoleAppLearning/output.txt";

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                using FileStream fsRead = new FileStream(
                    sourceFile,
                    FileMode.Open,
                    FileAccess.Read);

                using FileStream fsWrite = new FileStream(
                    destinationFile,
                    FileMode.Create,
                    FileAccess.Write);

                int byteData;

                while ((byteData = fsRead.ReadByte()) != -1)
                {
                    fsWrite.WriteByte((byte)byteData);
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    } 