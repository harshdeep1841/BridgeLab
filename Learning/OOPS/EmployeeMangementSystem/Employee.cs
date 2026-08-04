using ConsoleAppLearning1.Learning.OOPS.EmployeeMangementSystem;

namespace ConsoleAppLearning1.Learning.OOPS.EmployeeManagementSystem;

public abstract class Employee : IDepartment
{
    public long EmployeeId { get; }

    public string Name { get; set; }

    public decimal BaseSalary { get; protected set; }

    public string DepartmentName { get; private set; }

    protected Employee(long employeeId,
        string name,
        decimal baseSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract decimal CalculateSalary();

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Employee Id : {EmployeeId}");
        Console.WriteLine($"Name        : {Name}");
        Console.WriteLine($"Department  : {DepartmentName}");
        Console.WriteLine($"Salary      : {CalculateSalary()}");
    }

    public void AssignDepartment(string departmentName)
    {
        DepartmentName = departmentName;
    }

    public void GetDepartmentDetails()
    {
        Console.WriteLine($"Department : {DepartmentName}");
    }
}