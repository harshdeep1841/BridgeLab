namespace ConsoleAppLearning1.Learning.ExceptionHandling;

using System;
using System.IO;

    public class FileHandlingUsing
    {
        public void Execute()
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    string? firstLine = reader.ReadLine();

                    Console.WriteLine("First Line:");
                    Console.WriteLine(firstLine);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }