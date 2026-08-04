namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.VehicleRentalSystem;

public class Car : Vehicle , IInsurable
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }

    public Car(long id, VehicleType vehicleType, double rentalRate, string brand, string model, double price)
        : base(id, vehicleType, rentalRate)
    {
        Brand = brand;
        Model = model;
        Price = price;
    }

    public override double RentalCost(int days)
    {
        return days * RentalRate ;
    }

    public double CalculateInsuranceCost()
    {
        return Price * 0.1;
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Details");
        Console.WriteLine($"Insurance cost : {CalculateInsuranceCost()}");
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price}");
        
    }
}