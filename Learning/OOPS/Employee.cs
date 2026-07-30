namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class Employee
{
    private int id ;
    public string Name { get;set; }
    public int Salary { get; set; }

    public Employee(int id, string name, int salary)
    {
        this.id = id;
        this.Name = name;
        this.Salary = salary;
    }

    public  void display()
    {
        Console.WriteLine($"{this.id} - {this.Name} - {this.Salary}");
    }
    
}