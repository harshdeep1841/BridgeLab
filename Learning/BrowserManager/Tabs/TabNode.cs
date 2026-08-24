namespace BrowserManager.Models;

public class TabNode
{
    public BrowserTab Tab { get; set; }

    public TabNode Next { get; set; }

    public TabNode(BrowserTab tab)
    {
        Tab = tab;
    }
}