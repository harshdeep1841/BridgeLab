namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.LamdaExplore;

// public Action<string> delegate1;
public delegate void Delegate1(string s);
public delegate int Delegate2(int a, int b);
public class MultiCastDelegates
{
    private int cnt = 0;
    public  void Method1(string str) => Console.WriteLine($"this is {str} {cnt++}");
    public  void Method2(string str) => Console.WriteLine($"this is {str} {cnt++}");
    public  void Method3(string str) => Console.WriteLine($"this is {str}{cnt++}");
    
    public int Add(int a, int b) => a + b;
    public int  Multiply(int a, int b) => a * b;
    public int  Divide(int a, int b) => a / b;
    public int substract(int a, int b) => a - b;
    
    
}