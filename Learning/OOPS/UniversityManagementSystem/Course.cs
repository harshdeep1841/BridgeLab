namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.UniversityManagementSystem;

public class Course
{
    public string Title { get; set; }

    public int Credits { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Title} has started.");
    }
}