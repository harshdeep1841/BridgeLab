namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.IO;

    public class ReadUserInputAndWriteToFile
    {
        public static void WriteInput()
        {
            string filePath = "output.txt";

            try
            {
                using StreamWriter writer = new StreamWriter(filePath);

                Console.WriteLine("Enter text (type EXIT to stop):");

                while (true)
                {
                    string? input = Console.ReadLine();

                    if (input?.Equals("EXIT", StringComparison.OrdinalIgnoreCase) == true)
                        break;

                    writer.WriteLine(input);
                }

                Console.WriteLine("Data written successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }