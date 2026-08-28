namespace BrowserManager.Models;

public class LoadRequest
{
    public string Url { get; set; }
    public LoadRequest(string url)
    {
        Url = url;
    }

}