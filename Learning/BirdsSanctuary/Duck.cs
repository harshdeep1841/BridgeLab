namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.BirdsSanctuary;

public class Duck : Bird , IFlyable , ISyimable
{
    
    public void Fly()
    {
        Console.WriteLine("Duck is flying!");
    }

    public void Syim()
    {
        Console.WriteLine("Duck is syimming!");
    }
    
    public Duck(int id , string weight_catagory , Gender  gender) : base(id, weight_catagory, gender)
    {
    }
}