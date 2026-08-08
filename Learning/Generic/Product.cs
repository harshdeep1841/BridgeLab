namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic;

public class Product<T>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public T Category { get; set; }

    public Product(string name, decimal price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}