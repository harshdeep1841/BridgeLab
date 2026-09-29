namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.BirdsSanctuary;

public class Ostrich : Bird ,  IRunnable
{
    public int Height { get; set; }
    public void Run()
    {
        Console.WriteLine("Ostrich is  Runnning");
    }

    public Ostrich(int id , string weight_catagory , Gender  gender , int height) : base(id, weight_catagory, gender)
    {
        Height = height;
    }
}