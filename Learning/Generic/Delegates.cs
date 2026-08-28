namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;
public delegate void MathOp(int a , int b);
public class Delegates
{


    public static void Add(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }
}