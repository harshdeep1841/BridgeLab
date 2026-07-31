namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public enum RoomType
{
    Single,
    Double,
    Triple,
    Other
}
public class Hotel
{
    public string GuestName { get; set; }
    
    public RoomType RoomType { get; set; }
    
    public int Nights { get; set; }

    public Hotel()
    {
        this.GuestName = "Alex";
        this.RoomType = RoomType.Single;
        this.Nights = 0;
    }

    public Hotel(string guestName, RoomType roomType, int Nights)
    {
        this.GuestName = guestName;
        this.RoomType = roomType;
        this.Nights = Nights;
    }

    public Hotel(Hotel hotel)
    {
        GuestName = hotel.GuestName;
        RoomType = hotel.RoomType;
        Nights = hotel.Nights;
    }

}