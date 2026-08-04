namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size : {TeamSize}");
    }
}