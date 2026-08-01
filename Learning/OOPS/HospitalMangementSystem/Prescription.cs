namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Prescription
{
    public string Medicine { get; set; }

    public string Dosage { get; set; }

    public Doctor Doctor { get; }

    public Prescription(Doctor doctor,
        string medicine,
        string dosage)
    {
        Doctor = doctor;
        Medicine = medicine;
        Dosage = dosage;
    }

    public void PrintPrescription()
    {
        Console.WriteLine($"Doctor : {Doctor.Name}");
        Console.WriteLine($"Medicine : {Medicine}");
        Console.WriteLine($"Dosage : {Dosage}");
    }
}