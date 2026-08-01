namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Patient : Person
{
    public BloodGroup BloodGroup { get; set; }

    // Composition
    public Address Address { get; }

    // Composition
    public MedicalRecord MedicalRecord { get; }

    public Patient(long id,
        string name,
        int age,
        string gender,
        BloodGroup bloodGroup,
        Address address,
        MedicalRecord medicalRecord)
        : base(id, name, age, gender)
    {
        BloodGroup = bloodGroup;

        Address = new Address(address);

        MedicalRecord = medicalRecord;
    }

    public void Admit()
    {
        Console.WriteLine($"{Name} admitted.");
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Blood Group : {BloodGroup}");
    }
}