namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.Text;

    public class ReverseStringUsingStringBuilder
    {
        public static void Reverse()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine() ?? string.Empty;

            StringBuilder reversed = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            Console.WriteLine($"Reversed String: {reversed}");
        }
    } 