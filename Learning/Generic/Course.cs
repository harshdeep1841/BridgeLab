namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void DisplayCourses()
    {
        foreach (T course in courses)
        {
            course.Display();
        }
    }
}