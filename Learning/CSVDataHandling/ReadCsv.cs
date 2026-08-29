namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.CSVDataHandling;

public class ReadCsv
{
   
    public void Read()
    {
        string[] lines = File.ReadAllLines("students.csv");
        
        foreach (string line in lines.Skip(1))
        {
            string[] data = line.Split(',');
            Student student = new Student
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            };
        }
        
       
    }
}