using ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp;

namespace TestProject2;


public class PortfolioTests
{
    Portfolio<Holding> portfolio;
    [SetUp]
    public void SetUp()
    {
        portfolio = new Portfolio<Holding>();
    }
    
    [Test]
    public void Test1()
    {

        Holding apple =
            HoldingParser.Parse(
                "HOLDING:AAPL|QTY:100|COST:100|CURRENT:100|TARGET_WEIGHT:0.50");

        Holding microsoft =
            HoldingParser.Parse(
                "HOLDING:MSFT|QTY:100|COST:100|CURRENT:100|TARGET_WEIGHT:0.50");
        portfolio.Add(apple);
        portfolio.Add(microsoft);

        var actions = portfolio.Rebalance();

        Assert.That(actions, Is.Empty);
    }
    
    
    
    [Test]
    public void Test2()
    {

        Holding apple =
            HoldingParser.Parse(
                "HOLDING:AAPL|QTY:200|COST:100|CURRENT:100|TARGET_WEIGHT:0.50");

        Holding microsoft =
            HoldingParser.Parse(
                "HOLDING:MSFT|QTY:50|COST:100|CURRENT:100|TARGET_WEIGHT:0.50");

        portfolio.Add(apple);
        portfolio.Add(microsoft);

        var actions = portfolio.Rebalance();

        Assert.That(actions.Count, Is.EqualTo(1));

        Assert.That(
            actions[0].Ticker,
            Is.EqualTo("AAPL"));

        Assert.That(
            actions[0].Action,
            Is.EqualTo(ActionType.Buy));

        Assert.That(actions[0].Drift, Is.GreaterThan(0.001m));
    }
}