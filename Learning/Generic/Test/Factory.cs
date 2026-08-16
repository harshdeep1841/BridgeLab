namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Test;

public class Factory<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}