namespace ConsoleAppLearning1.Learning.Operator.Learning.Test.SmartHomeDevice;

public class Light : Device
{
  public int Brightness { get; set; }
  public Light() 
  {
    Brightness = 0;
  }

  public Light(string name , int brightness)  : base(name)
  {
    Brightness = brightness;
  }


  public override bool IsOn()
  {
    isOn = true;
    Console.WriteLine("light is on");
    return true;
  }

  public override bool IsOff()
  {
    isOn = false;
    Console.WriteLine("light is off");
    return true;
  }

  public void dim(int brightness)
  {
    if (brightness > 0 || brightness < 0)
    {
      throw new ArgumentException($"brigness cant be {brightness}");
    }

    Brightness = brightness;
    Console.WriteLine("light is dimmed");
  }
}