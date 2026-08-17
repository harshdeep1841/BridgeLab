using System.Text.RegularExpressions;

namespace ConsoleAppLearning1.Learning.Operator.Learning.PortfolioApp;

public static class HoldingParser
{
    private static readonly Regex HoldingRegex =
        new Regex(
            @"^HOLDING:(?<ticker>[A-Za-z]+)\|" +
            @"QTY:(?<quantity>\d+(?:\.\d+)?)\|" +
            @"COST:(?<cost>\d+(?:\.\d+)?)\|" +
            @"CURRENT:(?<current>\d+(?:\.\d+)?)\|" +
            @"TARGET_WEIGHT:(?<target>\d+(?:\.\d+)?)$"
        );

    public static Holding Parse(string input)
    {
        Match match = HoldingRegex.Match(input);

        if (!match.Success)
        {
            throw new FormatException(
                "Invalid holding format.");
        }

        string ticker =
            match.Groups["ticker"].Value;

        decimal quantity =
            decimal.Parse(match.Groups["quantity"].Value);

        decimal cost =
            decimal.Parse(match.Groups["cost"].Value);

        decimal currentPrice =
            decimal.Parse(match.Groups["current"].Value);

        decimal targetWeight =
            decimal.Parse(match.Groups["target"].Value);

        if (targetWeight < 0 || targetWeight > 1)
        {
            throw new ArgumentOutOfRangeException(
                "targetWeight",
                "Target weight must be between 0 and 1.");
        }

        return new Holding(
            ticker,
            quantity,
            cost,
            currentPrice,
            targetWeight);
    }
}
