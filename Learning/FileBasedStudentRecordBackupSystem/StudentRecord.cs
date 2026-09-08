namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.FileBasedStudentRecordBackupSystem;

public class StudentRecord
{
    public int Student_Id { get; set; }
    public string Name { get; set; }
    public char Grade { get; set; }
    public double Gpa  {get; set;}
    public DateTime EnrollmentDate { get; set; }

    public StudentRecord(int studentId, string name, char grade, double gpa, DateTime enrollmentDate)
    {
        Student_Id = studentId;
        Name = name;
        Grade = grade;
        Gpa = gpa;
        EnrollmentDate = enrollmentDate;
    }

    public StudentRecord()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{Student_Id} {Name} {Grade} {Gpa} {EnrollmentDate}";
    }
}