namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

using System;

public class CircularLinkedList
{
    private TaskNode head;
    private TaskNode currentTask;

    public void AddFirst(Task task)
    {
        TaskNode newNode = new TaskNode(task);

        if (head == null)
        {
            head = newNode;
            head.Next = head;
            currentTask = head;
            return;
        }

        TaskNode last = head;

        while (last.Next != head)
        {
            last = last.Next;
        }

        newNode.Next = head;
        last.Next = newNode;
        head = newNode;
    }

    public void AddLast(Task task)
    {
        TaskNode newNode = new TaskNode(task);

        if (head == null)
        {
            head = newNode;
            head.Next = head;
            currentTask = head;
            return;
        }

        TaskNode last = head;

        while (last.Next != head)
        {
            last = last.Next;
        }

        last.Next = newNode;
        newNode.Next = head;
    }

    public void AddAtPosition(Task task, int position)
    {
        if (position <= 1)
        {
            AddFirst(task);
            return;
        }

        TaskNode current = head;

        for (int i = 1; i < position - 1 && current.Next != head; i++)
        {
            current = current.Next;
        }

        TaskNode newNode = new TaskNode(task);

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void Remove(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty.");
            return;
        }

        TaskNode current = head;
        TaskNode previous = null;

        do
        {
            if (current.Data.TaskId == taskId)
            {
                if (current == head && head.Next == head)
                {
                    head = null;
                    currentTask = null;
                    return;
                }

                if (current == head)
                {
                    TaskNode last = head;

                    while (last.Next != head)
                    {
                        last = last.Next;
                    }

                    head = head.Next;
                    last.Next = head;

                    if (currentTask == current)
                        currentTask = head;

                    return;
                }

                previous.Next = current.Next;

                if (currentTask == current)
                    currentTask = current.Next;

                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);

        Console.WriteLine("Task Not Found.");
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No Tasks.");
            return;
        }

        TaskNode current = head;

        do
        {
            Console.WriteLine(current.Data);
            current = current.Next;

        } while (current != head);

        Console.WriteLine();
    }

    public void ViewCurrentTask()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No Current Task.");
            return;
        }

        Console.WriteLine("Current Task");
        Console.WriteLine(currentTask.Data);
    }

    public void MoveNext()
    {
        if (currentTask == null)
            return;

        currentTask = currentTask.Next;
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("List Empty");
            return;
        }

        bool found = false;

        TaskNode current = head;

        do
        {
            if (current.Data.Priority == priority)
            {
                Console.WriteLine(current.Data);
                found = true;
            }

            current = current.Next;

        } while (current != head);

        if (!found)
            Console.WriteLine("No Task Found.");
    }
}