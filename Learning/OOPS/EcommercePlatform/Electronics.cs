namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.EcommercePlatform;

public class Electronics : Product , ITaxable
{
    public int TaxPercentage { get; set; }
    public Electronics(){}
    
    public Electronics(long productId, string name, decimal price , int taxPercentage ) : base(productId, name, price)
    {
        TaxPercentage = taxPercentage;
    }
    public override decimal CalculateDiscount()
    {
        return  Price * (decimal)0.1;
    }

    public decimal FinalPrice()
    {
        return Price - (decimal)CalculateDiscount() + CalculateTax();
    }

    public decimal CalculateTax()
    {
        return Price * TaxPercentage / 100;
    }

    public void GetTaxDetails()
    {
        Console.WriteLine($"Tax Percentage: {TaxPercentage}");
    }
}