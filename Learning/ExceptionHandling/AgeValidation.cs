namespace ConsoleAppLearning1.Learning.ExceptionHandling;

using System;

    public class AgeValidation
    {
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above.");
            }

            Console.WriteLine("Access granted!");
        }

        public void Execute()
        {
            try
            {
                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid numeric age.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error:");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Validation completed.");
            }
        }
        
        
        
    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message)
            : base(message)
        {
        }
    }