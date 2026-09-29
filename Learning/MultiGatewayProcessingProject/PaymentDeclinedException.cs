namespace PaymentProcessing;

public class PaymentDeclinedException : Exception
{
    public string TransactionId { get; }

    public PaymentDeclinedException(
        string message,
        string transactionId)
        : base(message)
    {
        TransactionId = transactionId;
    }

    public PaymentDeclinedException(
        string message,
        string transactionId,
        Exception innerException)
        : base(message, innerException)
    {
        TransactionId = transactionId;
    }
}