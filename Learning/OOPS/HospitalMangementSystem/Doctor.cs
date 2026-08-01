namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Doctor : Person
{
    public string Specialization { get; set; }

    public decimal Salary { get; set; }

    public Department Department { get; set; }

    public Doctor(long id,
        string name,
        int age,
        string gender,
        string specialization,
        decimal salary)
        : base(id, name, age, gender)
    {
        Specialization = specialization;
        Salary = salary;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine(
            $"Dr. {Name} is consulting {patient.Name}");
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Specialization : {Specialization}");
    }
}