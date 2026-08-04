namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class Order
{
    public int OrderId { get; }

    public DateTime OrderDate { get; }

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    public virtual void Display()
    {
        Console.WriteLine($"Order Id : {OrderId}");
        Console.WriteLine($"Order Date : {OrderDate:d}");
    }
}