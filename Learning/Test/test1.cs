namespace ConsoleAppLearning1.Learning.Operator.Learning.Test;

using System.Collections.Generic;


public class Test1
{
    public void StackRecursionReverse(Stack<int> stack)
    {
        if (stack.Count == 0)
            return;

        int top = stack.Pop();

        StackRecursionReverse(stack);

        InsertAtBottom(stack, top);
    }

    private void InsertAtBottom(Stack<int> stack, int value)
    {
        if (stack.Count == 0)
        {
            stack.Push(value);
            return;
        }

        int top = stack.Pop();

        InsertAtBottom(stack, value);

        stack.Push(top);
    }

}
