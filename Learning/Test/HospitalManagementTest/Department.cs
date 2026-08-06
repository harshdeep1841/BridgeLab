namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.HospitalManagementTest;

public class Department
{
    public string DeptName { get; set; }
    private List<Doctor> doctors = new();
    public List<Doctor> Doctors { get => doctors; set => doctors = value; }
    
    public Department(){}

    public Department(string name)
    {
        DeptName = name;
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public void RemoveDoctor(Doctor doctor)
    {
        doctors.Remove(doctor);
    }
}