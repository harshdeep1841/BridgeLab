namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;

    public class UnsupportedCurrencyException : PaymentDeclinedException
    {
        public UnsupportedCurrencyException(string message)
            : base(message)
        {
            
        }

        
        
        public UnsupportedCurrencyException(string message, int transactionId)
            : base(message, transactionId)
        {
            
        }

        
        
        public UnsupportedCurrencyException(string message, int transactionId, Exception innerException)
            : base(message, transactionId, innerException)
        {
            
        }
    }
