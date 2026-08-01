namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public enum BloodGroup
{
    A_Positive,
    A_Negative,
    B_Positive,
    B_Negative,
    AB_Positive,
    AB_Negative,
    O_Positive,
    O_Negative
}

public class Person
{
    public long Id { get; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Gender { get; set; }

    protected Person()
    {
    }

    public Person(long id, string name, int age, string gender)
    {
        Id = id;
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Id : {Id}");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age : {Age}");
        Console.WriteLine($"Gender : {Gender}");
    }
}