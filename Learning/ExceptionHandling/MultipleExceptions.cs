namespace ConsoleAppLearning1.Learning.ExceptionHandling;

using System;

    public class MultipleExceptionHandling
    {
        public void Execute()
        {
            try
            {
                // int[] arr = null;

                int[] arr = { 10, 20, 30, 40, 50 };

                Console.Write("Enter Index: ");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Value at index {index}: {arr[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid index!");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Array is not initialized!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid integer.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }