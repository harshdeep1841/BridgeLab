namespace ConsoleAppLearning1.Learning.Reflection;

using System;
using System.Reflection;

partial class Student
{
    public string Name;

    private int age;

    public Student() { }

    public Student(string name)
    {
        Name = name;
    }

    public void Display() { }

    private void PrintAge() { }
}

class ReflectionClassInfo
{
    static void ReflectipnInfo()
    {
        Console.Write("Enter Class Name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods(
                     BindingFlags.Public |
                     BindingFlags.NonPublic |
                     BindingFlags.Instance |
                     BindingFlags.Static))
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields(
                     BindingFlags.Public |
                     BindingFlags.NonPublic |
                     BindingFlags.Instance |
                     BindingFlags.Static))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo constructor in type.GetConstructors(
                     BindingFlags.Public |
                     BindingFlags.NonPublic |
                     BindingFlags.Instance))
        {
            Console.WriteLine(constructor);
        }
    }
}