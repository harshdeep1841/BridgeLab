namespace ConsoleAppLearning1.Learning.Streams;

using System;
using System.IO;

    public class UserInputDemo
    {
        public static void SaveUserDetails()
        {
            string filePath = "/Users/harshdeepsingh/RiderProjects/ConsoleAppLearning/userdetails.txt";

            try
            {
                using StreamReader reader = new StreamReader(Console.OpenStandardInput());

                Console.Write("Enter Name: ");
                string name = reader.ReadLine();

                Console.Write("Enter Age: ");
                string age = reader.ReadLine();

                Console.Write("Enter Favorite Programming Language: ");
                string language = reader.ReadLine();

                using StreamWriter writer = new StreamWriter(filePath);

                writer.WriteLine("User Details");
                writer.WriteLine("----------------------");
                writer.WriteLine("Name      : " + name);
                writer.WriteLine("Age       : " + age);
                writer.WriteLine("Language  : " + language);

                Console.WriteLine("\nData saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }