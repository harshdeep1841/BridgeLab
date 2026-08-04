namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.MethodOverriding;

public class Animal
{
    protected string name;
   protected int age;

   protected Animal()
   {
       Console.WriteLine("Animal constructor");
       name = "Dog";
       age = 20;
   }

   protected Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine($"{this.name} {this.age}");
    }
    public  void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}