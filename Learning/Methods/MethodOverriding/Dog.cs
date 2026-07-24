using System.Transactions;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverriding;

public class Dog : Animal
{
    public  override void Speak()
    {
        
        Console.Write("Dog barks");
    }
}