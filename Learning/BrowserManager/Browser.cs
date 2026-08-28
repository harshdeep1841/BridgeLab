using BrowserManager.Managers;

using BrowserManager.Models;

namespace BrowserManager.Managers;

public class Browser
{
    private  TabManager tabManager = new TabManager();

    private  Stack<BrowserTab> closedTabs = new Stack<BrowserTab>();

    private  Queue<LoadRequest> loadingQueue = new Queue<LoadRequest>();



    public BrowserTab CurrentTab => tabManager.CurrentTab;

    public void OpenTab(string title)
    {
        tabManager.OpenTab(title);
    }

    public void SwitchTab()
    {
        tabManager.SwitchToNextTab();
    }

    public void CloseCurrentTab()
    {
        if (CurrentTab == null)
        {
            Console.WriteLine("No active tab.");
            return;
        }

        closedTabs.Push(CurrentTab);

        tabManager.CloseCurrentTab();
    }

    public void ReopenLastClosedTab()
    {
        if (closedTabs.Count == 0)
        {
            Console.WriteLine("No recently tabs");
            return;
        }

        BrowserTab tab = closedTabs.Pop();

        tabManager.OpenTab(tab.Title);
    
    }

    public void Visit(string url)
    {
        if (CurrentTab == null)
        {
            Console.WriteLine("Open a tab first.");
            return;
        }

        CurrentTab.History.Visit(url);

        Console.WriteLine($"Visited : {url}");
    }

    public void Back()
    {
        if (CurrentTab == null)
            return;
        if (!CurrentTab.History.Back())
            Console.WriteLine("No previous page.");
        else
        {
            Console.WriteLine(CurrentTab.Title);
        }
    }

    public void Forward()
    {
        if (CurrentTab == null)
            return;

        if (!CurrentTab.History.Forward())
            Console.WriteLine("No forward page.");
        else
        {
            Console.WriteLine(CurrentTab.Title);
        }
    }

    public void QueuePage(string url)
    {
        loadingQueue.Enqueue(new LoadRequest(url));
    }

    public void ProcessNextRequest()
    {
        if (loadingQueue.Count == 0)
        {
            Console.WriteLine("queue empty.");
            return;
        }

        LoadRequest request = loadingQueue.Dequeue();

        Console.WriteLine($"Loading : {request.Url}");
    }





    public void PrintCurrentHistory()
    {
        CurrentTab.History.PrintHistory();
    }

    public void PrintTabs()
    {
        tabManager.PrintTabs();
    }
}