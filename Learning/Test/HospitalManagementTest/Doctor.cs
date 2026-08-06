namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.HospitalManagementTest;

public class Doctor : Person
{
    public string Specification { get; set; }
    
    public Department Department { get; set; }
    
    public Doctor(){}

   public Doctor(long id, string name, int age, string specification, Department department) : base(id, name, age)
    {
        Specification = specification;
        Department = department;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Specfication: {Specification}");
        Console.WriteLine($"Department: {Department}");
    }
    
}