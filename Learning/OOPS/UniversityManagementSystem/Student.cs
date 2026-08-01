namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.UniversityManagementSystem;


public enum Specification
{
    CSE,
    Mechanical,
    Electrical,
    Aerospace,
    Chemical
}

public class Student : Person
{
    public long RollNo { get; set; }

    public int Cgpa { get; set; }

    public string Gender { get; set; }

    public Specification Specification { get; set; }

    // Composition
    public Address Address { get; private set; }

    // Association
    public Course Course { get; set; }

    public Student(
        long id,
        string name,
        long rollNo,
        int cgpa,
        string gender,
        Specification specification,
        Address address,
        Course course)
        : base(id, name)
    {
        RollNo = rollNo;
        Cgpa = cgpa;
        Gender = gender;
        Specification = specification;

        // Create our own Address to preserve composition
        Address = new Address(address);

        Course = course;
    }
}
    
    
