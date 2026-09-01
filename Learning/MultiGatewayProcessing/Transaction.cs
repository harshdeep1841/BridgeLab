namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;

    public class Transaction
    {
        public int TransactionId { get; set; }
        public int MerchantId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string MerchantCategory { get; set; }
        

        public Transaction(int transactionId, int merchantId, decimal amount, string currency, string merchantCategory)
        {
            TransactionId = transactionId;
            MerchantId = merchantId;
            Amount = amount;
            Currency = currency;
            MerchantCategory = merchantCategory;
        }
    } 