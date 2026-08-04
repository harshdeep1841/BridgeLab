namespace ConsoleAppLearning1.Learning.Operator.Learning.Methods.Inheritance;

public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; }

    public DeliveredOrder(
        int orderId,
        DateTime orderDate,
        string trackingNumber,
        DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }

    public override void Display()
    {
        base.Display();

        Console.WriteLine($"Delivery Date : {DeliveryDate:d}");
    }
}