using ClassLibrary1;

namespace TestProject1;


[TestFixture]
public class UnitTestAssignement
{
    private StringUtils stringUtils;
    private ListManager listManager;
    private DataBaseConnection dbConnection;
    private IsEven isEven;
    private LongRunningTask longRunningTask;
    [SetUp]
    public void SetUp()
    {
        stringUtils = new StringUtils();
        listManager = new ListManager();
        isEven = new IsEven();
        longRunningTask = new LongRunningTask();
    }

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        dbConnection = new DataBaseConnection();
    }
    
    

    [TestCase("Harsh")]
    [TestCase("WOW")]
    [TestCase("WOW WOW")]
    public void Test1(string str)
    {
        Assert.IsTrue(stringUtils.IsPalindrome(str));
        Assert.AreNotEqual(stringUtils.reverse(str), str);
    }
    [Test]
    public void Test2()
    {
        List<int> list = new List<int>();
        listManager.AddElement(list, 5);
        Assert.Contains(5 , list);
        listManager.RemoveElement(list, 5);
        Assert.IsFalse(list.Contains(5));
        
       Assert.AreEqual(listManager.GetSize(list) , list.Count); 
    }

    [Test]
    public void Test3()
    {
        Assert.Throws<DivideByZeroException>( () => Calculator.Divide(2 , 0));
    }

    [Test]
    public void Test4()
    {
        dbConnection.Connect();
        Assert.IsTrue(dbConnection.IsConnected);
        dbConnection.Disconnect();
        Assert.IsFalse(dbConnection.IsConnected);
    }

    [TestCase(3)]
    [TestCase(5)]
    public void Test5(int num)
    {
        Assert.IsFalse(isEven.IsEvenNum(num));
    }
    [Timeout(6000)]
    [Test]
    public void Test6()
    {
        longRunningTask.LongTask();
    }
    
    


    [TearDown]
    public void TearDown()
    {
        stringUtils = null;
        listManager = null;
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        dbConnection =  null;
    }
    
}