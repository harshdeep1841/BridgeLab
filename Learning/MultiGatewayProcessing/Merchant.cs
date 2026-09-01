namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

    public class Merchant
    {
        public int MerchantId { get; set; }
        public string RiskTier { get; set; }
        
        

        public Merchant(int merchantId, string riskTier)
        {
            MerchantId = merchantId;
            RiskTier = riskTier;
        }

    }