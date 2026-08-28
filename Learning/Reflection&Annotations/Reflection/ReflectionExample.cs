using System.Reflection;

namespace ConsoleAppLearning1.Learning.Reflection;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class ReflectionExample
{
    static Type type  = typeof(Employee);
    FieldInfo fieldInfo = type.GetField("Name" , BindingFlags.NonPublic | BindingFlags.Instance);
    
}