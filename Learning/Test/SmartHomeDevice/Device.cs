namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.SmartHomeDevice;

public abstract class Device
{
    public string Name{get;set;}
    protected bool isOn = false;
    public Device(){}
   public Device(string name)
    {
        Name = name;
    }

   public Device(string name, bool on)
    {
        Name = name;
        isOn = on;
    }
    
   

    abstract public bool IsOn();
    abstract public bool IsOff();
    
    

}