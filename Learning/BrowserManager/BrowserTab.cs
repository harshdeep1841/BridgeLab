
using BrowserManager.Managers;
namespace BrowserManager.Models;

public class BrowserTab
{
    public string Title { get; set; }

    public BrowserHistory History { get; }

    public BrowserTab(string title)
    {
        Title = title;
        History = new BrowserHistory();
    }
}