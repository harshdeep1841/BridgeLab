namespace ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp;

public interface IHolding
{
    string Ticker { get; }
    decimal Quantity { get; }
    decimal Cost { get; }
    decimal CurrentPrice { get; }
    decimal TargetWeight { get; }

    decimal CurrentValue { get; }
}