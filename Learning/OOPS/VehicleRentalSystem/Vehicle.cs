namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS.VehicleRentalSystem;

public enum VehicleType
{
    Car,
    Truck,
    Activa,
    Bike
}

public abstract class Vehicle
{
    public long Id { get; set; }
    public VehicleType VehicleType { get; set; }
    public double RentalRate { get; set; }

    public abstract double RentalCost(int days);
    
    public Vehicle(long id, VehicleType vehicleType , double rentalRate)
    {
        Id = id;
        VehicleType = vehicleType;
        RentalRate = rentalRate;
    }

    public virtual void Display()
    {
        Console.WriteLine($"VehicleId: {Id}");
        Console.WriteLine($"VehicleType: {VehicleType}");
    }

}