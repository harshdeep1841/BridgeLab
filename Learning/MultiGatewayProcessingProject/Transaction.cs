namespace PaymentProcessing;

public class Transaction
{
    public string TransactionId { get; set; }
    public string MerchantId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string MerchantCategory { get; set; }

    public Transaction(
        string transactionId,
        string merchantId,
        decimal amount,
        string currency,
        string merchantCategory)
    {
        TransactionId = transactionId;
        MerchantId = merchantId;
        Amount = amount;
        Currency = currency;
        MerchantCategory = merchantCategory;
    }
}