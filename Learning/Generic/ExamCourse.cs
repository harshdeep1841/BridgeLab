namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class ExamCourse : CourseType
{
    public ExamCourse(string name)
        : base(name)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Exam Course: {Name}");
    }
}