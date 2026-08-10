namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public class Image : Media
{
    public Image(string url)
        : base(url)
    {
    }

    public override void Display()
    {
        Console.WriteLine(
            $"Displaying image: {Url}"
        );
    }
}