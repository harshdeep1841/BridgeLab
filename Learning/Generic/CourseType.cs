namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public abstract class CourseType
{
    public string Name { get; set; }

    protected CourseType(string name)
    {
        Name = name;
    }

    public abstract void Display();
}