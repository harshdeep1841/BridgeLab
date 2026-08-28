namespace ConsoleAppLearning1.Learning.Reflection;

using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionPrivateMethod
{
    static void ReflectionMethod()
    {
        Calculator calc = new Calculator();

        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod(
            "Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance);

        int result = (int)method.Invoke(calc, new object[] { 5, 10 });

        Console.WriteLine(result);
    }
}