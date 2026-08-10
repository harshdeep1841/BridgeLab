namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class Groceries : WarehouseItem
{
    public Groceries(int id, string name)
        : base(id, name)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"Groceries: {Name}");
    }
}