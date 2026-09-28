using System.Reflection;

namespace PaymentProcessing;

public class PaymentProcessor
{
    private readonly Dictionary<string, Merchant> merchants;

    private readonly List<Transaction> settled = new();
    private readonly List<Transaction> flagged = new();
    private readonly List<Transaction> declined = new();

    public event Action<Transaction>? TransactionSettled;
    public event Action<Transaction>? TransactionFlaggedForReview;

    public Action<Transaction>? Logger { get; set; }

    public PaymentProcessor(List<Merchant> merchants)
    {
        this.merchants = merchants.ToDictionary(
            m => m.MerchantId);
    }


    public void ProcessBatch(List<Transaction> transactions)
    {
        CheckBatch(transactions);

        foreach (Transaction transaction in transactions)
        {
            ProcessTransaction(transaction);
        }
    }


    private void ProcessTransaction(Transaction transaction)
    {
        try
        {
            List<Func<Transaction, bool>> rules =
                CreateRules(transaction);

            bool passed = rules.All(
                rule => rule(transaction));

            if (!passed)
            {
                throw new PaymentDeclinedException(
                    "Transaction failed rules.",
                    transaction.TransactionId);
            }

            Merchant merchant =
                merchants[transaction.MerchantId];

            if (NeedsReview(merchant))
            {
                flagged.Add(transaction);
                TransactionFlaggedForReview?.Invoke(transaction);
            }

            settled.Add(transaction);
            TransactionSettled?.Invoke(transaction);
        }
        catch (UnsupportedCurrencyException ex)
        {
            declined.Add(transaction);
            Logger?.Invoke(transaction);

            Console.WriteLine(
                $"Unsupported currency: {ex.Currency}");
        }
        catch (PaymentDeclinedException ex)
        {
            declined.Add(transaction);
            Logger?.Invoke(transaction);

            Console.WriteLine(
                $"Declined: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            declined.Add(transaction);
            Logger?.Invoke(transaction);

            Console.WriteLine(
                $"Overflow: {ex.Message}");
        }
    }


    private List<Func<Transaction, bool>> CreateRules(
        Transaction transaction)
    {
        if (transaction.MerchantCategory == "Retail")
        {
            return new List<Func<Transaction, bool>>
            {
                RuleFactory.CreateAmountLimitRule(50000),

                RuleFactory.CreateCurrencyRule(
                    new[] { "USD", "EUR", "INR" })
            };
        }

        if (transaction.MerchantCategory == "Travel")
        {
            return new List<Func<Transaction, bool>>
            {
                RuleFactory.CreateAmountLimitRule(200000),

                RuleFactory.CreateCurrencyRule(
                    new[] { "USD", "EUR", "GBP", "JPY" })
            };
        }

        return new List<Func<Transaction, bool>>
        {
            RuleFactory.CreateAmountLimitRule(10000),

            RuleFactory.CreateCurrencyRule(
                new[] { "USD", "EUR" })
        };
    }


    private bool NeedsReview(Merchant merchant)
    {
        MethodInfo? reviewMethod =
            typeof(PaymentProcessor).GetMethod(
                nameof(ReviewTransaction),
                BindingFlags.NonPublic |
                BindingFlags.Instance);

        MethodInfo? riskMethod =
            typeof(PaymentProcessor).GetMethod(
                nameof(HighRiskMerchant),
                BindingFlags.NonPublic |
                BindingFlags.Instance);

        bool manualReview =
            reviewMethod?.GetCustomAttribute<
                RequiresManualReviewAttribute>() != null;

        RiskTierAttribute? risk =
            riskMethod?.GetCustomAttribute<
                RiskTierAttribute>();

        return manualReview &&
               risk != null &&
               merchant.RiskTier == risk.RiskTier;
    }

    [RequiresManualReview]
    private void ReviewTransaction()
    {
    }

    [RiskTier("High")]
    private void HighRiskMerchant()
    {
    }


    private void CheckBatch(List<Transaction> transactions)
    {
        if (transactions.Count < 5 ||
            transactions.Count > 100)
        {
            throw new ArgumentException(
                "Batch must contain 5-100 transactions.");
        }

        bool duplicate =
            transactions
                .GroupBy(t => t.TransactionId)
                .Any(g => g.Count() > 1);

        if (duplicate)
        {
            throw new InvalidOperationException(
                "Duplicate TransactionId found.");
        }
    }

        
    
}