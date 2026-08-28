namespace ConsoleAppLearning1.Learning.Reflection.AttributeExample;

using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Harshdeep")]
class Employee
{
}

class ReflectionAttributeExample
{
    static void ReflectionAttribute()
    {
        Type type = typeof(Employee);

        AuthorAttribute attribute =
            (AuthorAttribute)Attribute.GetCustomAttribute(
                type,
                typeof(AuthorAttribute));

        Console.WriteLine(attribute.Name);
    }
}