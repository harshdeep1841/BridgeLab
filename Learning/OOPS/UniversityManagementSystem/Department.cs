namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.UniversityManagementSystem;

public class Department
{
    public string Name { get; set; }

    private readonly List<Teacher> teachers = new();

    public IReadOnlyList<Teacher> Teachers => teachers;

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        teachers.Remove(teacher);
    }
}