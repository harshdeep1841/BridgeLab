namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language : {ProgrammingLanguage}");
    }
}