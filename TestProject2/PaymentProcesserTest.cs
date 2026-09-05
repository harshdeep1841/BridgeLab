using ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.MultiGatewayProcessing;
using NuGet.Frameworks;

namespace TestProject2;

using NUnit.Framework;
    public class PaymentProcessorTests
    {
        
        private PaymentProcessor processor;
        private Merchant merchant;
        [SetUp]
        public void Setup()
        {
            processor = new PaymentProcessor();

            processor.AddRule(
                RuleFactory.CreateAmountLimitRule(50000));

            processor.AddRule(
                RuleFactory.CreateCurrencyRule(
                    new[] { "USD", "EUR", "INR", "GBP", "JPY" }));
        }

        [Test]
        public void TransactionPassesAllRules()
        {
            bool settled = false;

            processor.TransactionSettled += t => settled = true;

            Transaction transaction =
                new Transaction(1, 101, 20000, "USD", "Retail");

            processor.ProcessTransaction(transaction);

            Assert.IsTrue(settled);
        }

        [Test]
        public void TransactionFailsAmountRules()
        {
            bool settled = false;

            processor.TransactionSettled += t => settled = true;

            Transaction transaction =
                new Transaction(2, 102, 80000, "USD", "Retail");

            processor.ProcessTransaction(transaction);

            Assert.IsFalse(settled);
        }

        [Test]
        public void UnsupportedCurrencyRule()
        {
            bool settled = false;

            processor.TransactionSettled += t => settled = true;

            Transaction transaction =
                new Transaction(3, 103, 1000, "AUD", "Retail");

            processor.ProcessTransaction(transaction);

            Assert.IsFalse(settled);
        }

        [Test]
        public void HighAmountIsFlagged()
        {
            bool flagged = false;

            processor.TransactionFlaggedForReview += t => flagged = true;

            Transaction transaction =
                new Transaction(4, 104, 50000, "USD", "Retail");

            processor.ProcessTransaction(transaction);

            Assert.IsFalse(flagged);

            transaction =
                new Transaction(5, 104, 60000, "USD", "Retail");

            processor.ProcessTransaction(transaction);

            Assert.IsTrue(flagged);
        }

        [Test]
        public void ClosureAmountRule()
        {
            Func<Transaction , bool> rule = RuleFactory.CreateAmountLimitRule(10000);

            Transaction transaction =
                new Transaction(6, 101, 9000, "USD", "Retail");

            Assert.IsTrue(rule(transaction));
        }

        [Test]
        public void ClosureAmountRuleFails()
        {
            Func<Transaction , bool> rule = RuleFactory.CreateAmountLimitRule(10000);

            Transaction transaction =
                new Transaction(7, 101, 15000, "USD", "Retail");

            Assert.IsFalse(rule(transaction));
            
        }

        [Test]
        public void CurrencyRulePasses()
        {
            var rule =
                RuleFactory.CreateCurrencyRule(
                    new[] { "USD", "INR" });

            Transaction transaction =
                new Transaction(8, 101, 1000, "USD", "Retail");

            Assert.IsTrue(rule(transaction));
        }

        [Test]
        public void CurrencyRuleFails()
        {
            var rule =
                RuleFactory.CreateCurrencyRule(
                    new[] { "USD", "INR" });

            Transaction transaction =
                new Transaction(9, 101, 1000, "EUR", "Retail");

            Assert.IsFalse(rule(transaction));
        }


        [Test]
        public void LoggerTest()
        {
            bool envoke = false;
            processor.Logger  = (t) =>
            {
                envoke = true;
                Console.WriteLine("data is saved");
            };
            
            Transaction transaction =
                new Transaction(1, 101, 20000, "USD", "Retail");
            processor.ProcessTransaction(transaction);
            Assert.IsTrue(envoke);
        }
        
        [Test]
        public void MerchantConstructor_SetsPropertiesCorrectly()
        {
            merchant =  new Merchant(101, "High");

            Assert.AreEqual(101, merchant.MerchantId);
            Assert.AreEqual("High", merchant.RiskTier);
        }

    }
