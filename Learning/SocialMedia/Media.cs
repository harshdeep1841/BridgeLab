namespace ConsoleAppLearning1.Learning.Operator.Learning.SocialMedia;

public abstract class Media
{
    public string Url { get; }

    protected Media(string url)
    {
        Url = url;
    }

    public abstract void Display();
}