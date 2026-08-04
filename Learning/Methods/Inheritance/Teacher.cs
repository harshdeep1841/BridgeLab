namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name,
        int age,
        string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role : Teacher");
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Subject : {Subject}");
    }
}