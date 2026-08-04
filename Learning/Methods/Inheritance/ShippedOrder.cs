namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class ShippedOrder : Order
{
    public string TrackingNumber { get; }

    public ShippedOrder(
        int orderId,
        DateTime orderDate,
        string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Tracking Number : {TrackingNumber}");
    }
}