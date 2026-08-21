using ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp;

namespace ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp
{
    using System;
}

    public class Portfolio<T> where T : IHolding
    {
        private Dictionary<string, T> holdings =
            new Dictionary<string, T>();

        private const decimal DriftThreshold = 0.0001m;

        public void Add(T holding)
        {
            holdings[holding.Ticker] = holding;
        }

        public T GetHolding(string ticker)
        {
            return holdings[ticker];
        }

        public decimal TotalValue
        {
            get
            {
                return holdings.Values
                    .Sum(h => h.CurrentValue);
            }
        }

        public List<RebalanceAction> Rebalance()
        {
            decimal targetTotal =
                holdings.Values
                    .Sum(h => h.TargetWeight);

            if (Math.Abs(targetTotal - 1.0m)
                > DriftThreshold)
            {
                throw new InvalidOperationException(
                    "Target weights must add up to 1.0.");
            }

            decimal totalValue = TotalValue;

            if (totalValue <= 0)
            {
                throw new InvalidOperationException(
                    "Portfolio value must be greater than zero.");
            }

            return holdings.Values

                .Select(h => new
                {
                    Holding = h,
                    CurrentWeight =
                        h.CurrentValue / totalValue
                })

                .Select(x => new
                {
                    Holding = x.Holding,

                    CurrentWeight =
                        x.CurrentWeight,

                    Drift =
                        x.CurrentWeight
                        - x.Holding.TargetWeight
                })

                .Where(x =>
                    Math.Abs(x.Drift)
                    > DriftThreshold)

                .Select(x => new RebalanceAction
                {
                    Ticker = x.Holding.Ticker,

                    CurrentWeight =
                        x.CurrentWeight,

                    TargetWeight =
                        x.Holding.TargetWeight,

                    Drift =
                        x.Drift,

                    Action =
                        x.Drift > 0
                            ? ActionType.Sell
                            : ActionType.Buy
                })
                .ToList();
        }
    } 

