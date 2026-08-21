namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.Text;

    public class RemoveDuplicatesUsingStringBuilder
    {
        public static void RemoveDuplicates()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine() ?? string.Empty;

            StringBuilder result = new StringBuilder();

            foreach (char ch in input)
            {
                if (!result.ToString().Contains(ch))
                {
                    result.Append(ch);
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    } 