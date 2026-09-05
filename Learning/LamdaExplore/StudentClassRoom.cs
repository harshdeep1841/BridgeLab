namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.LamdaExplore;

public class StudentClassRoom
{
    public string Name { get; set; }
    public int Score { get; set; }
    public bool HasPassed { get; set; }
    public StudentClassRoom(string name, int score)
    {
        Name = name;
        Score = score;
        HasPassed = score >= 50;
    }
    
}