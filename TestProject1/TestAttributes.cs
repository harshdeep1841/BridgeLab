using System.Diagnostics;

namespace TestProject1;

public class TestAttributes
{
    [Conditional("DEBUG")]
    public void Display()
    {
        Console.WriteLine("Display");
    }
}