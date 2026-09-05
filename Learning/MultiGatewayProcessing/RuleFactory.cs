namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;
using System.Linq;

    public static class RuleFactory
    {
        public static Func<Transaction, bool> CreateAmountLimitRule(decimal limit)
        {
            return transaction => transaction.Amount <= limit;
        }
        

        public static Func<Transaction, bool> CreateCurrencyRule(string[] allowedCurrencies)
        {
            return transaction => allowedCurrencies.Contains(transaction.Currency);
            
        }

        public static Func<Transaction, bool> CreateCategoryRule(string category)
        {
            return transaction => transaction.MerchantCategory == category;
        }
        
        
    }
