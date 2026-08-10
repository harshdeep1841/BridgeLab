namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.SmartHomeDevice;

public class Thermostat : Device
{
    public int Temperature { get; set; }

    Thermostat()
    {
        Temperature = 30;
    }

    Thermostat(string name, int temp) : base(name)
    {
        IsOn(); 
        Temperature = temp;
    }

    public override bool IsOn()
    {
        isOn = true;
        Console.WriteLine($"{Name} is on");
        return isOn;
    }

    public override bool IsOff()
    {
        Temperature = 30;
        isOn = false;
        Console.WriteLine($"{Name} is off");
        return true;
    }
    
    public void SetTemperature(int temp)
    {
        Temperature = temp;
    }
}