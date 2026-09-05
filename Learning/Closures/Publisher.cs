namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.Closures;

class Publisher
{
    public event Action Event;

    public void Raise()
    {
        Event?.Invoke();
    }
}

class Subscriber
{
    public Subscriber(Publisher publisher)
    {
        publisher.Event += Handler;
    }

    void Handler()
    {
        Console.WriteLine("Handled");
    }
}