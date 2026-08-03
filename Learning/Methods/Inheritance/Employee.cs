namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine($"Name   : {Name}");
        Console.WriteLine($"Id     : {Id}");
        Console.WriteLine($"Salary : {Salary}");
    }
}