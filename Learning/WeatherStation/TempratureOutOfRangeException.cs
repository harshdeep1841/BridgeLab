namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

public class TemperatureOutOfRangeException : WeatherException
{
    public TemperatureOutOfRangeException(string code)
        : base($"Temperature out of range for {code}")
    {
        
    }
}