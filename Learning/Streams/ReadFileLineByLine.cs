namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.IO;

    public class ReadFileLineByLine
    {
        public static void ReadLines()
        {
            string filePath = "input.txt";

            try
            {
                using StreamReader reader = new StreamReader(filePath);

                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
