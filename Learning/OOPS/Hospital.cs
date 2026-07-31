namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

using System;

public class Patient
{
    public static string HospitalName = "City Hospital";

    private static int totalPatients = 0;

    public readonly int PatientID;

    public string Name { get; set; }
    public int Age { get; set; }
    public string Ailment { get; set; }

    private static int nextPatientId = 1001;

    public Patient(string name, int age, string ailment)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        PatientID = nextPatientId++;
        totalPatients++;
    }

    public static int GetTotalPatients()
    {
        return totalPatients;
    }

    public void Display()
    {
        Console.WriteLine($"Hospital   : {HospitalName}");
        Console.WriteLine($"Patient ID : {PatientID}");
        Console.WriteLine($"Name       : {Name}");
        Console.WriteLine($"Age        : {Age}");
        Console.WriteLine($"Ailment    : {Ailment}");
        Console.WriteLine();
    }
}