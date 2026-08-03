namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("I am a person.");
    }

    public virtual void Display()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age : {Age}");
    }
}