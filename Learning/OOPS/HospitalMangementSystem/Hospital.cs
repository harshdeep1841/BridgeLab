namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Hospital
{
    public string Name { get; set; }

    private readonly List<Department> departments = new();

    private readonly List<Patient> patients = new();

    public Hospital(string name)
    {
        Name = name;
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public void RegisterPatient(Patient patient)
    {
        patients.Add(patient);

        Console.WriteLine($"{patient.Name} registered successfully.");
    }
}