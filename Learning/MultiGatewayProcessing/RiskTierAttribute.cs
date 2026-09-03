namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;

    [AttributeUsage(AttributeTargets.Class )]
    public class RiskTierAttribute : Attribute
    {
        public string Tier { get; }
        
        public RiskTierAttribute(string tier)
        {
            Tier = tier;
        }
    }