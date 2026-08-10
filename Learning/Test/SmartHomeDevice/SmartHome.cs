namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.SmartHomeDevice;

public class SmartHome
{
    public List<Room> rooms;
    public List<Device> devices;


    public void AddRoom(Room room)
    {
        rooms.Add(room);
        Console.WriteLine("Room Added");
    }

    public void AddDevice(Device device)
    {
        devices.Add(device);
        Console.WriteLine("Device Added");
    }
}