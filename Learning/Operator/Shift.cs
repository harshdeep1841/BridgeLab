namespace Operators;

public class ShiftOperators
{
    public void func()
    {
        int value = 5;

        Console.WriteLine(value << 1);
        Console.WriteLine(value << 2);

        Console.WriteLine(value >> 1);
    }
}