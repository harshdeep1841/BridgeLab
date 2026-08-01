namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;

public class Patient
{
    public int Id { get; set; }

    public string Name { get; set; }
    
    Patient() {}

    public Patient(int id, string name)
    {
        Id = id;
        Name = name;
    }
}