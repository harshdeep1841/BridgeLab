namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.EcommercePlatform;

public class Groceries : Product
{
    public Groceries(){}
    
    public Groceries(long productId, string name, decimal price ) : base(productId, name, price)
    {
    }
    public override decimal CalculateDiscount()
    {
        return  Price * (decimal)0.3;
    }

    public decimal FinalPrice()
    {
        return Price - (decimal)CalculateDiscount() ;
    }

    
}