namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.VehicleRentalSystem;

public class Truck : Vehicle, IInsurable
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
    public double LoadCapacity { get; set; }

    public Truck(long id,
        VehicleType vehicleType,
        double rentalRate,
        string brand,
        string model,
        double price,
        double loadCapacity)
        : base(id, vehicleType, rentalRate)
    {
        Brand = brand;
        Model = model;
        Price = price;
        LoadCapacity = loadCapacity;
    }

    public override double RentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsuranceCost()
    {
        return Price * 0.15; // 15% Insurance
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance Details");
        Console.WriteLine($"Insurance Cost : {CalculateInsuranceCost()}");
    }

    public override void Display()
    {
        {
            base.Display();
            
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Load Capacity : {LoadCapacity} Tons");
        }
    }

}