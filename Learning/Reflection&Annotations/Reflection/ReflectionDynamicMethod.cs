namespace ConsoleAppLearning1.Learning.Reflection;

using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;
}

class ReflectionDynamicMethod
{
    static void ReflectionMethod()
    {
        MathOperations math = new MathOperations();

        Console.Write("Enter Method Name: ");
        string methodName = Console.ReadLine();

        Type type = typeof(MathOperations);

        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        object result = method.Invoke(math, new object[] { 20, 10 });

        Console.WriteLine(result);
    }
}