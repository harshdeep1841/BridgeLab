namespace ConsoleAppLearning1.Learning.Operator.Learning.Test;

public class Animal
{
    public string name;
    
    public long age;

    public virtual void Display()
    {
    }
}

public class Dog : Animal
{
    public  void Display()
    {
        Console.Write("this is dog");
    }
}