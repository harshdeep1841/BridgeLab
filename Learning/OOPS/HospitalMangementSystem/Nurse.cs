namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Nurse : Person
{
    public string Shift { get; set; }

    public Nurse(long id,
        string name,
        int age,
        string gender,
        string shift)
        : base(id, name, age, gender)
    {
        Shift = shift;
    }

    public void Assist()
    {
        Console.WriteLine($"{Name} is assisting.");
    }
}