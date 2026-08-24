using BrowserManager.Models;
using ConsoleAppLearning1.Learning.Operator.Learning.Test.TaskSchedular;

namespace BrowserManager.Managers;

public class TabManager
{
    private TabNode head;
    private TabNode current;

    public BrowserTab? CurrentTab =>  current?.Tab;
    public void OpenTab(string title)
    {
        BrowserTab tab = new BrowserTab(title);
        TabNode node = new (tab);

        if (head == null)
        {
            head = node;
            current = node;
            node.Next = node;
            return;
        }

        TabNode last = head;

        while (last.Next != head)
        {
            last = last.Next;
        }

        last.Next = node;
        node.Next = head;

        current = node;
    }

    public bool SwitchToNextTab()
    {
        if (current == null)
            return false;

        current = current.Next;
        return true;
    }

    public bool CloseCurrentTab()
    {
        if (current == null)
            return false;

        if (current == head && current.Next == head)
        {
            head = null;
            current = null;
            return true;
        }

        TabNode previous = current;

        while (previous.Next != current)
        {
            previous = previous.Next;
        }
        
        previous.Next = current.Next;
        if (current == head)
        {
            head = current.Next;
        }

        current = current.Next;

        return true;
    }

    public void PrintTabs()
    {
        if (head == null)
        {
            Console.WriteLine("No Tabs");
            return;
        }

        TabNode temp = head.Next;

        while(temp != head)
        { 
            Console.Write($"{temp.Tab.Title} ");

            temp = temp.Next;
        }

        Console.WriteLine();
    }
}