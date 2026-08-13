namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

using System;

public class MovieLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    public void AddFirst(Movie movie)
    {
        MovieNode newNode = new MovieNode(movie);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Previous = newNode;
        head = newNode;
    }

    public void AddLast(Movie movie)
    {
        MovieNode newNode = new MovieNode(movie);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Previous = tail;
        tail = newNode;
    }

    public void AddAtPosition(Movie movie, int position)
    {
        if (position <= 1)
        {
            AddFirst(movie);
            return;
        }

        MovieNode current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Invalid Position.");
            return;
        }

        if (current == tail)
        {
            AddLast(movie);
            return;
        }

        MovieNode newNode = new MovieNode(movie);

        newNode.Next = current.Next;
        newNode.Previous = current;

        current.Next.Previous = newNode;
        current.Next = newNode;
    }

    public void Remove(string title)
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty.");
            return;
        }

        MovieNode current = head;

        while (current != null &&
               !current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Movie Not Found.");
            return;
        }

        if (head == tail)
        {
            head = tail = null;
            return;
        }

        if (current == head)
        {
            head = head.Next;
            head.Previous = null;
            return;
        }

        if (current == tail)
        {
            tail = tail.Previous;
            tail.Next = null;
            return;
        }

        current.Previous.Next = current.Next;
        current.Next.Previous = current.Previous;
    }

    public void SearchByDirector(string director)
    {
        MovieNode current = head;
        bool found = false;

        while (current != null)
        {
            if (current.Data.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(current.Data);
                found = true;
            }

            current = current.Next;
        }

        if (!found)
            Console.WriteLine("No Movies Found.");
    }

    public void SearchByRating(double rating)
    {
        MovieNode current = head;
        bool found = false;

        while (current != null)
        {
            if (current.Data.Rating == rating)
            {
                Console.WriteLine(current.Data);
                found = true;
            }

            current = current.Next;
        }

        if (!found)
            Console.WriteLine("No Movies Found.");
    }

    public void UpdateRating(string title, double newRating)
    {
        MovieNode current = head;

        while (current != null)
        {
            if (current.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                current.Data.Rating = newRating;
                Console.WriteLine("Rating Updated Successfully.");
                return;
            }

            current = current.Next;
        }

        Console.WriteLine("Movie Not Found.");
    }

    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty.");
            return;
        }

        MovieNode current = head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

        Console.WriteLine();
    }

    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("List is Empty.");
            return;
        }

        MovieNode current = tail;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Previous;
        }

        Console.WriteLine();
    }
}