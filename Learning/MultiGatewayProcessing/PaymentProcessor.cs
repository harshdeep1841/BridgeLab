namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;

using System;
using System.Collections.Generic;
using System.Linq;
    public class PaymentProcessor
    {
        public event Action<Transaction> TransactionSettled;
        public event Action<Transaction> TransactionFlaggedForReview;

        public Action<Transaction> Logger;

        
        
        private List<Func<Transaction, bool>> rules =
            new List<Func<Transaction, bool>>();

        public void AddRule(Func<Transaction, bool> rule)
        {
            
            rules.Add(rule);
        }

        public void ProcessTransaction(Transaction transaction)
        {
            try
            {
                string[] supportedCurrencies = {
                    "USD", "EUR", "INR", "GBP", "JPY"
                };

                if (!supportedCurrencies.Contains(transaction.Currency))
                {
                    throw new UnsupportedCurrencyException(
                        "Unsupported currency.",
                        transaction.TransactionId);
                }

                bool passed = rules.All(rule => rule(transaction));
                
                if (!passed)
                {
                    throw new PaymentDeclinedException(
                        "Transaction declined.",
                        transaction.TransactionId);
                }

                if (transaction.Amount > 50000)
                {
                    TransactionFlaggedForReview?.Invoke(transaction);
                }

                TransactionSettled?.Invoke(transaction);

                Logger?.Invoke(transaction);
            }
            catch (UnsupportedCurrencyException e)
            {
                Console.WriteLine($"Currency Error: {e.Message}");
            }
            catch (PaymentDeclinedException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        public void ProcessBatch(List<Transaction> transactions)
        {
            foreach (var transaction in transactions)
            {
                ProcessTransaction(transaction);
            }
        }
    }
