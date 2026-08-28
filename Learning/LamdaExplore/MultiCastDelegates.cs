namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.LamdaExplore;

// public Action<string> delegate1;
public delegate void Delegate1(string s);
public class MultiCastDelegates
{
    public  void Method1(string str) => Console.WriteLine($"this is {str}");
    public  void Method2(string str) => Console.WriteLine($"this is {str}");
    public  void Method3(string str) => Console.WriteLine($"this is {str}");
    
    
}