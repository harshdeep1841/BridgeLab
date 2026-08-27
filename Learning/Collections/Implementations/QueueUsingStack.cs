using System.Diagnostics;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.Implementations;

public class QueueUsingStack
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();
    
   
    public void Enqueue(int value)
    {
        stack1.Push(value);
    }
    
    public int Dequeue()
    {
        if (stack1.Count == 0)
        {
            Console.WriteLine("queue is empty");
            return -1;
        }

        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Pop();
    }

    public int Peek()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Peek();
    }

    public bool isEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0 ?  true : false;
    }
}