namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.WeatherStation;

public class InvalidHumidityException : WeatherException
{
    public InvalidHumidityException(int humidity)
        : base($"Invalid Humidity : {humidity}")
    {
        
    }
}