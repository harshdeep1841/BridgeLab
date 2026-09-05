namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.LamdaExplore;

public class LamdaSample
{
    public void Sample()
    {
        //zero paramters
        Action ShowCase = () => {Console.WriteLine("Hello World");};
        ShowCase();
        
        //1 Paramter
        Func<int, int> num = (a) => a * a;
        Console.WriteLine(num(10));
        
        //2 Parameters
        Func<int, int , int> num2 = (a, b) => a * b;
        Console.WriteLine(num2(10, 20));


    }
}