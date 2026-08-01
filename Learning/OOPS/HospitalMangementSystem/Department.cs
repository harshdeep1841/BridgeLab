namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.HospitalMangementSystem;


public class Department
{
    public string Name { get; set; }

    private readonly List<Doctor> doctors = new();

    public IReadOnlyList<Doctor> Doctors => doctors;

    public Department(string name)
    {
        Name = name;
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);

        doctor.Department = this;
    }

    public void RemoveDoctor(Doctor doctor)
    {
        doctors.Remove(doctor);
    }
}