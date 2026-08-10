namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class Electronics : WarehouseItem
{
    public Electronics(int id, string name)
        : base(id, name)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Electronics: {Name}");
    }
}