namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.EcommercePlatform;

public class Clothing : Product
{
    public Clothing(){}
    
    public Clothing(long productId, string name, decimal price ) : base(productId, name, price)
    {
    }
    public override decimal CalculateDiscount()
    {
        return  Price * (decimal)0.2;
    }

    public decimal FinalPrice()
    {
        return Price - (decimal)CalculateDiscount() ;
    }

    
}