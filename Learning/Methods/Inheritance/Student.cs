namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class Student : Person
{
    public int Grade { get; set; }

    public Student(string name,
        int age,
        int grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role : Student");
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Grade : {Grade}");
    }
}