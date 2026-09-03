namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;
 
    public class PaymentDeclinedException : Exception
    {
        public int TransactionId { get; }

        public PaymentDeclinedException(string message)
            : base(message)
        {
        }

        public PaymentDeclinedException(string message, int transactionId)
            : base(message)
        {
            TransactionId = transactionId;
        }

        public PaymentDeclinedException(string message, int transactionId, Exception innerException)
            : base(message, innerException)
        {
            TransactionId = transactionId;
        }
    }
