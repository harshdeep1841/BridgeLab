using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverriding;

public class Dog : Animal
{
    

   public Dog(string name, int age) : base(name, age) //base is used to call base contructer  ,
                                                      //and by default it calls default constructer
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("call from Dog");
    }
    public  override void Speak()
    {
        Console.Write("Dog barks");
    }
}