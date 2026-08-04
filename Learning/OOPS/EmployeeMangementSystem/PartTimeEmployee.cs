namespace ConsoleAppLearning1.Learning.OOPS.EmployeeManagementSystem;

public class PartTimeEmployee : Employee
{
    public int HoursWorked { get; set; }

    public decimal HourlyRate { get; set; }

    public PartTimeEmployee(long employeeId,
        string name,
        int hoursWorked,
        decimal hourlyRate)
        : base(employeeId, name, 0)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Hours Worked : {HoursWorked}");
        Console.WriteLine($"Hourly Rate  : {HourlyRate}");
    }
}