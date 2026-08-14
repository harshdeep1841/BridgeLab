namespace ConsoleAppLearning1.Learning.Operator.Learning.Collections.AssignementDataStructures;

using System;

public class StudentLinkedList
{
    private Node head;

    public void AddFirst(Student student)
    {
        Node newNode = new Node(student);

        newNode.Next = head;
        head = newNode;
    }

    public void AddLast(Student student)
    {
        Node newNode = new Node(student);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public void AddAtPosition(Student student, int position)
    {
        if (position <= 1)
        {
            AddFirst(student);
            return;
        }

        Node newNode = new Node(student);
        Node current = head;

        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }
        

        if (current == null)
        {
            Console.WriteLine("Invalid Position.");
            return;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void DeleteByRollNumber(int rollNumber)
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty.");
            return;
        }

        if (head.Data.RollNumber == rollNumber)
        {
            head = head.Next;
            Console.WriteLine("Student Deleted.");
            return;
        }

        Node previous = null;
        Node current = head;

        while (current != null && current.Data.RollNumber != rollNumber)
        {
            previous = current;
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Student Not Found.");
            return;
        }

        previous.Next = current.Next;

        Console.WriteLine("Student Deleted.");
    }

    public Student Search(int rollNumber)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Data.RollNumber == rollNumber)
                return current.Data;

            current = current.Next;
        }

        return null;
    }

    public void UpdateGrade(int rollNumber, char newGrade)
    {
        Student student = Search(rollNumber);

        if (student == null)
        {
            Console.WriteLine("Student Not Found.");
            return;
        }

        student.Grade = newGrade;

        Console.WriteLine("Grade Updated Successfully.");
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty.");
            return;
        }

        Node current = head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

        Console.WriteLine();
    }
}