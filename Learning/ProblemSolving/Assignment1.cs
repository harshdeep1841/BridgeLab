namespace ConsoleAppLearning1.Learning.Operator.Learning.ProblemSolving;

public class Assignment1
{
    public static void WelcomeToBridgelabz()
    {
        Console.WriteLine("Welcome to Bridgelabz!");
    }
    
    public static void AddTwoNumbers()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum = " + (num1 + num2));
    }
    
    public static void CelsiusToFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
    }
    
    public static void AreaOfCircle()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area = " + area);
    }
    
    public static void VolumeOfCylinder()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double volume = Math.PI * radius * radius * height;

        Console.WriteLine("Volume = " + volume);
    }
    
    
    public static void CalculateSimpleInterest()
    {
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());

        double interest = (principal * rate * time) / 100;

        Console.WriteLine("Simple Interest = " + interest);
    }
    
    public static void PowerCalculation()
    {
        Console.Write("Enter Base: ");
        double baseNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter Exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNumber, exponent);

        Console.WriteLine("Result = " + result);
    }
    
    
}