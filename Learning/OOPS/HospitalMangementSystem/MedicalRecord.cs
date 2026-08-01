namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class MedicalRecord
{
    public int RecordId { get; }

    public string Diagnosis { get; set; }

    public string Allergies { get; set; }

    public MedicalRecord(int id,
        string diagnosis,
        string allergies)
    {
        RecordId = id;
        Diagnosis = diagnosis;
        Allergies = allergies;
    }

    public void PrintRecord()
    {
        Console.WriteLine($"Record Id : {RecordId}");
        Console.WriteLine($"Diagnosis : {Diagnosis}");
        Console.WriteLine($"Allergies : {Allergies}");
    }
}