namespace ConsoleAppLearning1.Learning.Operator.Learning.OOPS;

public class Circle
{
    public int Radius { get; set; }
//AutoProperty (work as variable from outside but work as set/ get from inside)

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public double GetArea()
    {
        return (double)(22 * Radius * Radius)/7;
    }

    public double GetPerimeter()
    {
        return (double)(2 * 22 *Radius) / 7;
    }
}