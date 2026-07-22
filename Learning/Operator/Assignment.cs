namespace Operators;

public class AssignmentOperators
{
    public void func()
    {
        int x = 10;

        x += 5;
        x -= 2;
        x *= 3;
        x /= 2;
        x %= 4;

        Console.WriteLine(x);
    }
}