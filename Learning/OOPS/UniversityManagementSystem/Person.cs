namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.UniversityManagementSystem;

public class Person
{
    public long Id { get; }

    public string Name { get; set; }

    protected Person()
    {
    }

    public Person(long id, string name)
    {
        Id = id;
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Id : {Id}");
        Console.WriteLine($"Name : {Name}");
    }
}