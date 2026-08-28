namespace ConsoleAppLearning1.Learning.Reflection;

using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "ABC123";
}

class ReflectionStaticField
{
    static void ReflectionStaticFields()
    {
        Type type = typeof(Configuration);

        FieldInfo field = type.GetField(
            "API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static);

        Console.WriteLine("Before: " + field.GetValue(null));

        field.SetValue(null, "XYZ999");

        Console.WriteLine("After : " + field.GetValue(null));
    }
}