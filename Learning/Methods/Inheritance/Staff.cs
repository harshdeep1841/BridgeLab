namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name,
        int age,
        string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role : Staff");
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Department : {Department}");
    }
}