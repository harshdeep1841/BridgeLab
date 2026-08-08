namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class Furniture : WarehouseItem
{
    public Furniture(int id, string name)
        : base(id, name)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Furniture: {Name}");
    }
}