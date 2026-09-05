namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.Closures;

public class ClosuresSample
{
    public Func<int> CreatingRunningCounter()
    {
        int val = 0;

        return () => val += 10;
    }
}