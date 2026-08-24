using BrowserManager.Models;
using Microsoft.VisualBasic;

namespace BrowserManager.Managers;

public class BrowserHistory
{
    private HistoryNode head;
    private HistoryNode tail;
    private HistoryNode current;

    public string CurrentUrl => current.Url;
    public void Visit(string url)
    {
        HistoryNode node = new HistoryNode(url);

        if (head == null)
        {
            head = tail = current = node;
            return;
        }
        
        if (current != tail)
        {
            
            current.Next = null;
            tail = current;
        }

        tail.Next = node;
        node.Previous = tail;
        tail = node;
        current = node;
    }

    public bool Back()
    {
        if (current == null || current.Previous == null)
            return false;

        current = current.Previous;
        return true;
    }

    public bool Forward()
    {
        if (current == null || current.Next == null)
            return false;

        current = current.Next;
        return true;
    }

    public void PrintHistory()
    {
        if (head == null) return;
        HistoryNode temp = head;
        
        while (temp != null)
        {
            if (temp == current)
                Console.Write($"[{temp.Url}] ");
            else
                Console.Write($"{temp.Url} ");

            temp = temp.Next;
        }

        Console.WriteLine();
    }
}