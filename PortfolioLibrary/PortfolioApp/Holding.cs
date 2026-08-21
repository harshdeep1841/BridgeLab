namespace ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp;

public class Holding : IHolding
{
    public string Ticker { get; set; }

    public decimal Quantity { get; set; }

    public decimal Cost { get; set; }

    public decimal CurrentPrice { get; set; }

    public decimal TargetWeight { get; set; }

    public decimal CurrentValue
    {
        get { return Quantity * CurrentPrice; }
    }

    public Holding(
        string ticker,
        decimal quantity,
        decimal cost,
        decimal currentPrice,
        decimal targetWeight)
    {
        Ticker = ticker;
        Quantity = quantity;
        Cost = cost;
        CurrentPrice = currentPrice;
        TargetWeight = targetWeight;
    }
}