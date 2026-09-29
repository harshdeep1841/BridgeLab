namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.BirdsSanctuary;

public class Penguin : Bird , ISyimable 
{
    public void Syim()
    {
        Console.WriteLine("Penguin is swimming");
    }
    public Penguin(int id , string weight_catagory , Gender  gender) : base(id, weight_catagory, gender)
    {
    }
}