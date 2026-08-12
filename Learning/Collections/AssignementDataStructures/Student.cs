namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; }

    public Student(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"Roll: {RollNumber}, Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}

public class Node
{
    public Student Data { get; set; }
    public Node Next { get; set; }

    public Node(Student student)
    {
        Data = student;
        Next = null;
    }
}