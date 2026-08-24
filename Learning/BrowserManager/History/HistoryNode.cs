namespace BrowserManager.Models;

public class HistoryNode
{
    public string Url { get; set; }

    public HistoryNode Previous { get; set; }

    public HistoryNode Next { get; set; }
    public HistoryNode(string url) 
    {
        Url = url;
    }
    
}