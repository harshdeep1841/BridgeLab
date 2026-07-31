namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class Employee
{
    private int id ;
    public string Name { get;set; }
    public int Salary { get; set; }

    private string email;
     string Email
     {
         get { return email;} set
     {
         if (!string.IsNullOrWhiteSpace(value) && Email.Length > 10 && Email == Email.ToLower())
         {
             email = value;
         }
     }
         
     }

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