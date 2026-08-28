namespace ConsoleAppLearning1.Learning.Reflection;

using System;
using System.Reflection;

class Person
{
    private int age = 20;
}

class ReflectionPrivateField
{
    static void ReflectionField()
    {
        Person person = new Person();

        Type type = typeof(Person);

        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(person, 30);

        Console.WriteLine(field.GetValue(person));
    }
}