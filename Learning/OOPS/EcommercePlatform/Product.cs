namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.EcommercePlatform;

public abstract class Product
{
    public long ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    public Product(){}

   public Product(long productId, string name, decimal price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }
    
    public abstract decimal CalculateDiscount();
}