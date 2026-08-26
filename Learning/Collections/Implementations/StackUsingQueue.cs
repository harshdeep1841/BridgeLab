namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.Implementations;

public class StackUsingQueue
{
    private Queue<int> queue = new Queue<int>();

    public void push(int value)
    {
        queue.Enqueue(value);
        int cnt = queue.Count;
        while (cnt > 1)
        {
            queue.Enqueue(queue.Dequeue());
            cnt--;
        }
        
    }

    public int pop()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("stack is empty");
            return -1;
        }
       return queue.Dequeue();
    }

    public int peek()
    {
       return queue.Peek();
    }

    public bool isEmpty()
    {
        return queue.Count == 0 ? true : false;
    }
}