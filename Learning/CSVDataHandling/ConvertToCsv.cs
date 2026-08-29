namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.CSVDataHandling;

public class ConvertToCsv
{
    public void ToCsv()
    {
        List<Employee> employees = new()
        {
            new Employee{Id=1,Name="Amit",Department="IT",Salary=50000},
            new Employee{Id=2,Name="Riya",Department="HR",Salary=42000},
            new Employee{Id=3,Name="Rahul",Department="IT",Salary=65000},
            new Employee{Id=4,Name="Sneha",Department="Finance",Salary=55000},
            new Employee{Id=5,Name="Karan",Department="IT",Salary=70000},
        };
        
        List<string> lines = new();

        lines.Add("Id,Name,Department,Salary");

        foreach(Employee emp in employees)
        {
            lines.Add($"{emp.Id},{emp.Name},{emp.Department},{emp.Salary}");
        }
        File.WriteAllLines("employees.csv", lines);
        
    }
}