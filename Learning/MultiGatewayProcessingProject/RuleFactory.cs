namespace PaymentProcessing;

public static class RuleFactory
{
    public static Func<Transaction, bool> CreateAmountLimitRule(
        decimal limit)
    {
        return transaction =>
            transaction.Amount <= limit;
    }

    public static Func<Transaction, bool> CreateCurrencyRule(
        string[] allowedCurrencies)
    {
        var allowedCurrenciesSet =
            new HashSet<string>(
                allowedCurrencies,
                StringComparer.OrdinalIgnoreCase);

        return transaction =>
        {
            if (!allowedCurrenciesSet.Contains(
                    transaction.Currency))
            {
                throw new UnsupportedCurrencyException(
                    transaction.Currency);
            }

            return true;
        };
    }
}