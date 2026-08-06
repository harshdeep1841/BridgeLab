using ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.HospitalManagementTest;

public enum BloodType
{
A_Positive,
A_Negative,
B_Positive,
B_Negative,
AB_Positive,
AB_Negative,
O_Positive,
O_Negative
}

public class Patient : Person
{
    //address , medicalRecord , BloodGroup , 
    public BloodType BloodType;
    public Address Address { get; set; }
    public MedicalRecord MedicalRecord { get; set; }
    
    Patient(){}

    Patient(int id, string name, int age, BloodType bloodType, Address address, MedicalRecord medicalRecord) : base(id , name , age)
    {
        BloodType = bloodType;
        Address = address;
        MedicalRecord = medicalRecord;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Blood Type: {BloodType}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Medical Record: {MedicalRecord}");
    }
}