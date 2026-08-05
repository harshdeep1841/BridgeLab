namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.EcommercePlatform;

public abstract class Product
{
    public long ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    static int NumberOfProducts;
    static Product()
    {
        NumberOfProducts = 1;
    }
    
    public Product(){}

   public Product(long productId, string name, decimal price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        NumberOfProducts++;
    }
    
    public abstract decimal CalculateDiscount();
}