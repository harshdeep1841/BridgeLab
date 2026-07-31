namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public enum CarModel 
{
    Tata_Nexon, Maruti_Suzuki_Swift,Hyundai_Creta
}

public class CarRental
{
    private static IReadOnlyDictionary<CarModel, int> PriceModel = new Dictionary<CarModel, int>()
    {
        { CarModel.Tata_Nexon, 100 },
        { CarModel.Maruti_Suzuki_Swift, 200 },
        { CarModel.Hyundai_Creta, 500 }
    };
    public string CustomerName { get; set; }
    public CarModel CarModel { get; set; }
    public int RentalDays { get; set; }

    public CarRental(string customerName, CarModel carModel , int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    public int TotalCost()
    {
        return PriceModel[CarModel] * RentalDays;
    }
}