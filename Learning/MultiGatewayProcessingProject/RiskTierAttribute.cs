namespace PaymentProcessing;

[AttributeUsage(AttributeTargets.Method)]
public class RiskTierAttribute : Attribute
{
    public string RiskTier { get; }

    public RiskTierAttribute(string riskTier)
    {
        RiskTier = riskTier;
    }
}