using BrowserManager.Models;

namespace ConsoleAppLearning1.Learning.BrowserManager;

public class BookmarkManager
{
    private  List<Bookmark> bookmarks = new List<Bookmark>();
    
    public void AddBookmark(string name, string url)
    {
        bookmarks.Add(new Bookmark(name, url));

        bookmarks.Sort((a, b) =>
            string.Compare(a.Name, b.Name,
                StringComparison.OrdinalIgnoreCase));
    }
    
    public Bookmark? Search(string name)
    {
        int left = 0;
        int right = bookmarks.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int compare = string.Compare(
                bookmarks[mid].Name,
                name,
                StringComparison.OrdinalIgnoreCase);
            
            
            if (compare == 0)
                return bookmarks[mid];

            if (compare < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}