namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.JsonDataHandling;

public class Match
{
    public long MatchId { get; set; }
    public string Team1 {get; set;}
    public string Team2 {get; set;}
    public Dictionary<string , int> Score {get; set;}
    public string Winner {get; set;}
    public string Player_Of_Match {get; set;}
}