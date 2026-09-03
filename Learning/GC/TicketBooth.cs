namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.GC;

public class TicketBooth : IDisposable
{
    public void Dispose()
    {
        // TODO release managed resources here
       
        
    }
    
    public void SellTicket() => Console.WriteLine("Ticket Sell");
    public void BuyTicket() => Console.WriteLine("Ticket Buy");
}
