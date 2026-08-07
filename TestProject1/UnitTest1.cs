using ClassLibrary1;

namespace TestProject1;

[TestFixture]
public class Tests
{
    private PrimeNumber prime;
    [SetUp]
    public void Setup()
    {
         prime = new PrimeNumber();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void PrimeTest()
    {
        bool isPrime = prime.IsPrime(8);
        Assert.IsFalse(isPrime);
    }
    
    [Test]
    public void CalculatorTesting()
    {
        Console.Write(Calculator.Add(1, 2));
        Assert.AreEqual(Calculator.Add(1, 2) , 3);
    }

    [TestCase(1 ,2 , 3)]
    [TestCase(2 , 3 , 5)]
    public void CalculatorTest2(int a , int b , int result)
    { 
        int res = Calculator.Add(a, b);
        Assert.AreEqual(res, result);
    }

    [Test]
    public void CalculatorTest3()
    {
            Assert.Throws<DivideByZeroException>( () => Calculator.Divide(1, 0));
    }

    public void CalculatorTest4()
    {
        
    }
    

    [TearDown]
    public void TearDown()
    {
        prime = null;
        
    }
}