namespace PaymentProcessing;

public class UnsupportedCurrencyException : Exception
{
    public string Currency { get; }

    public UnsupportedCurrencyException(string currency)
        : base($"Currency {currency} is not supported.")
    {
        Currency = currency;
    }
}