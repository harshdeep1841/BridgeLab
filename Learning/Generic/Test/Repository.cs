namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Test;

public class Repository<T> where T : Entity
{
    public void PrintName(T entity)
    {
        Console.WriteLine(entity.Name);
    }
}