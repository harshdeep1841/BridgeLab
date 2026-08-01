namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.UniversityManagementSystem;

public class Teacher : Person
{
    public int Salary { get; set; }

    // Aggregation 1 to many
    public Department Department { get; set; }

    public Teacher()
    {
    }

    public Teacher(
        long id,
        string name,
        int salary)
        : base(id, name)
    {
        Salary = salary;
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching.");
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Salary : {Salary}");
    }
}