namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Internship Duration : {InternshipDuration}");
    }
}