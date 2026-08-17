namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Test;

public class Student
{
    // public Student()
    // {
    //     Console.WriteLine("Hello World!");
    // }
    public int Id { get; set; }
    public string Name { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Student()
    {
    }
}