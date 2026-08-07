namespace ClassLibrary1;

public class LongRunningTask
{
    public LongRunningTask(){}
    
    public void LongTask()
    {
        Thread.Sleep(5000);
    }
}