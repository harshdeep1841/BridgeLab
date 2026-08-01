namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;

public class Doctor
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Doctor(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine(
            $"Dr. {Name} is consulting patient {patient.Name}");
    }
}