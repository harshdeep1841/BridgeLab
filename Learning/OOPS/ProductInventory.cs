namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class ProductInventory
{
    public string ProductName { get; set; }
    public Double Price { get; set; }
    public static int TotalProducts = 0;
    
    ProductInventory(){}

    ProductInventory(string productName, Double price)
    {
        ProductName = productName;
        Price = price;
        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: {ProductName} and its Price: {Price}");
    }

    public static int DisplayTotalProducts()
    {
        return TotalProducts;
    }
}