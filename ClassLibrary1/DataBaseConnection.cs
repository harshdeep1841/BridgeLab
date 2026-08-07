namespace ClassLibrary1;

public class DataBaseConnection
{
    
    public bool IsConnected = false;
   public DataBaseConnection(){}
    
    public void Connect()
    {
        IsConnected = true;
        Console.WriteLine("Connecting to database...");
    }

    public void Disconnect()
    {
        IsConnected = false;
        Console.WriteLine("Disconnecting from database...");
    }
}