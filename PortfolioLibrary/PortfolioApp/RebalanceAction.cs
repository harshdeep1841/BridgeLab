namespace ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp;

public  class RebalanceAction
{
    public string Ticker { get; set; } = "";

    public ActionType Action { get; set; }

    public decimal CurrentWeight { get; set; }

    public decimal TargetWeight { get; set; }

    public decimal Drift { get; set; }
}

