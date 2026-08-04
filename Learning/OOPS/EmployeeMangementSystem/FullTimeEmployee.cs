namespace ConsoleAppLearning1.Learning.OOPS.EmployeeManagementSystem;

public class FullTimeEmployee : Employee
{
    public decimal Bonus { get; set; }

    public FullTimeEmployee(long employeeId,
        string name,
        decimal baseSalary,
        decimal bonus)
        : base(employeeId, name, baseSalary)
    {
        Bonus = bonus;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Bonus       : {Bonus}");
    }
}