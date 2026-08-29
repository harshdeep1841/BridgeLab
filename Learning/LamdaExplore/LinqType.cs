namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.LamdaExplore;

public class LinqType
{
    public void LinqSql()
    {
        List<StudentClassRoom> classRoom = new List<StudentClassRoom>();
        classRoom.Add(new StudentClassRoom("HARSH" , 80));
        classRoom.Add(new StudentClassRoom("DIVYAM" , 30));
        classRoom.Add(new StudentClassRoom("HARMAN" , 50));
        classRoom.Add(new StudentClassRoom("JASKARAN" , 60));
        classRoom.Add(new StudentClassRoom("KESHAV" , 65));
        classRoom.Add(new StudentClassRoom("HARSAINYAM" , 80));

        var score = from student in classRoom where student.Score >= 40
            orderby  student.Name.Length descending select student;
        foreach (var student in score)
        {
            Console.WriteLine(student.Name);
        }
        
    }
}