namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class AssignmentCourse : CourseType
{
    public AssignmentCourse(string name)
        : base(name)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Assignment Course: {Name}");
    }
}