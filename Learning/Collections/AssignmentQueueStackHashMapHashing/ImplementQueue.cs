namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignmentQueueStackHashMapHashing;

public class ImplementQueue
{
    public Stack<int> stack = new Stack<int>();
    public Stack<int> top = new Stack<int>();
    public int Add(int value)
    {
        stack.Push(value);
        return value;
    }

    public void Remove()
    {
        foreach (int i in stack)
        {
            top.Push(i);
        }

        top.Pop();
        
    }

    public void Display()
    {
        foreach(int i in stack)
        {
            
        }
        foreach (int i in stack)
        {
            Console.Write($"{i} ");
        }
    }
    
}