namespace TestProject2;

using NUnit.Framework;
using PaymentProcessing;


[TestFixture]
public  class PaymentProcessorTestProject
{
    private List<Merchant> merchants = null!;
    private PaymentProcessor processor = null!;

    [SetUp]
    public void Setup()
    {
        merchants =
        [
            new Merchant("M1", "Low"),
            new Merchant("M2", "Medium"),
            new Merchant("M3", "High")
        ];

        processor = new PaymentProcessor(merchants);
    }

    [Test]
    public void ValidTransaction()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T2", "M1", 2000m, "USD", "Retail"),

            new Transaction(
                "T3", "M1", 3000m, "USD", "Retail"),

            new Transaction(
                "T4", "M1", 4000m, "USD", "Retail"),

            new Transaction(
                "T5", "M1", 5000m, "USD", "Retail")
        };

        int settled = 0;

        processor.TransactionSettled +=
            transaction => settled++;

        processor.ProcessBatch(transactions);

        Assert.That(settled, Is.EqualTo(5));
    }


    [Test]
    public void AmountLimitExceeded()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M1", 60000m, "USD", "Retail"),

            new Transaction(
                "T2", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T3", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T4", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T5", "M1", 1000m, "USD", "Retail")
        };

        int settled = 0;

        processor.TransactionSettled +=
            transaction => settled++;

        processor.ProcessBatch(transactions);

        Assert.That(settled, Is.EqualTo(4));
    }


    [Test]
    public void UnsupportedCurrency()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M1", 1000m, "CAD", "Retail"),

            new Transaction(
                "T2", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T3", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T4", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T5", "M1", 1000m, "USD", "Retail")
        };

        int settled = 0;

        processor.TransactionSettled +=
            transaction => settled++;

        processor.ProcessBatch(transactions);

        Assert.That(settled, Is.EqualTo(4));
    }


    [Test]
    public void HighRiskMerchant()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T2", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T3", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T4", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T5", "M3", 1000m, "USD", "Retail")
        };

        int flagged = 0;

        processor.TransactionFlaggedForReview +=
            transaction => flagged++;

        processor.ProcessBatch(transactions);

        Assert.That(flagged, Is.EqualTo(5));
    }


    [Test]
    public void LowRiskMerchant()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T2", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T3", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T4", "M1", 1000m, "USD", "Retail"),

            new Transaction(
                "T5", "M1", 1000m, "USD", "Retail")
        };

        int flagged = 0;

        processor.TransactionFlaggedForReview +=
            transaction => flagged++;

        processor.ProcessBatch(transactions);

        Assert.That(flagged, Is.EqualTo(0));
    }


    [Test]
    public void HighRiskTransaction()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T2", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T3", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T4", "M3", 1000m, "USD", "Retail"),

            new Transaction(
                "T5", "M3", 1000m, "USD", "Retail")
        };

        int flagged = 0;
        int settled = 0;

        processor.TransactionFlaggedForReview +=
            transaction => flagged++;

        processor.TransactionSettled +=
            transaction => settled++;

        processor.ProcessBatch(transactions);

        Assert.That(flagged, Is.EqualTo(5));
        Assert.That(settled, Is.EqualTo(5));
    }


    [Test]
    public void DifferentCategories()
    {
        var retailRule =
            RuleFactory.CreateAmountLimitRule(50000m);

        var cryptoRule =
            RuleFactory.CreateAmountLimitRule(10000m);

        var retailTransaction =
            new Transaction(
                "T1", "M1", 20000m, "USD", "Retail");

        var cryptoTransaction =
            new Transaction(
                "T2", "M1", 20000m, "USD", "Crypto");

        Assert.That(
            retailRule(retailTransaction),
            Is.True);

        Assert.That(
            cryptoRule(cryptoTransaction),
            Is.False);
    }


    [Test]
    public void CurrencyRule()
    {
        var rule =
            RuleFactory.CreateCurrencyRule(
                new[] { "USD", "EUR" });

        var transaction =
            new Transaction(
                "T1", "M1", 100m, "USD", "Retail");

        Assert.That(
            rule(transaction),
            Is.True);
    }




    // 10. Duplicate transaction ID
    [Test]
    public void DuplicateTransactionId()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M1", 100m, "USD", "Retail"),

            new Transaction(
                "T1", "M1", 200m, "USD", "Retail"),

            new Transaction(
                "T3", "M1", 300m, "USD", "Retail"),

            new Transaction(
                "T4", "M1", 400m, "USD", "Retail"),

            new Transaction(
                "T5", "M1", 500m, "USD", "Retail")
        };

        Assert.Throws<InvalidOperationException>(
            () => processor.ProcessBatch(transactions));
    }


    [Test]
    public void BatchWithLessThanFiveTransactions()
    {
        var transactions = new List<Transaction>
        {
            new Transaction(
                "T1", "M1", 100m, "USD", "Retail")
        };

        Assert.Throws<ArgumentException>(
            () => processor.ProcessBatch(transactions));
    }

}