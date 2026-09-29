namespace PaymentProcessing;


public class Merchant
{
    public string MerchantId { get; set; }
    public string RiskTier { get; set; }

    public Merchant(string merchantId, string riskTier)
    {
        MerchantId = merchantId;
        RiskTier = riskTier;
    }
}