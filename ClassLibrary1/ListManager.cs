namespace ClassLibrary1;

public class ListManager
{
    
   public ListManager(){}

    public int AddElement(List<int> list, int element)
    {
        list.Add(element);
        return element;
    }

    public int RemoveElement(List<int> list, int element)
    {
        list.Remove(element);
        return element;
    }

    public int GetSize(List<int> list)
    {
        return list.Count;
    }
}