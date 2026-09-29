namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

public class UnknownStationException : WeatherException
{
    public UnknownStationException(string code)
        : base($"Unknown Station : {code}")
    {
        
    }
}