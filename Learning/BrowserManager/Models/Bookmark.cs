namespace BrowserManager.Models;

public class Bookmark
{
    public string Name { get; set; }
    public string Url { get; set; }

    public Bookmark(string name, string url)
    {
        Name = name;
        Url = url;
    }
    
}