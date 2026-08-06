using System.ComponentModel.Design;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.HospitalManagementTest;

public class Person
{
    public long Id { get; set; }
     public string Name { get; set; }
     public int Age { get; set; }
     
    public  Person(){}

    public Person(long id , string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    
    public virtual void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}