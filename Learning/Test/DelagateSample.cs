namespace ConsoleAppLearning1.Learning.Operator.Learning.Test;

public class DelagateSample
{
    public Action func1()
    {
        int closure1 = 1;
        return () => Console.WriteLine($"Hello func1 {closure1}");
    }
    
    public Action func2()
    {
        int closure2 = 1;
        return () => Console.WriteLine($"Hello func2 {closure2}");
    }
}