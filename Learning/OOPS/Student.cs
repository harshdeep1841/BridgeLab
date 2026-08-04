namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class Student
{
    public int rollNumber;
    protected string name;
    private double cgpa;
    
     int RollNumber { get; set; }
    string Name { get; set; }
    
    public Student(){}

    public double Cgpa
    {
        get => cgpa;
       private set
        {
            if (value > 0 && value <= 10)
            {
                cgpa = value;
            }
        }
    }
    
    public Student(int rollNumber, string name , double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.Cgpa = cgpa;
    }

    public void Display()
    {
        throw new NotImplementedException();
    }
}

public class PostgraduateStudent : Student
{
    public PostgraduateStudent() : base()
    {}
    
    public PostgraduateStudent(int  rollNumber, string name , double cgpa) : base(rollNumber, name, cgpa)
    {
    }
    
}